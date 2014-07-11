using System;
using System.Threading;

using DarkTech.Common.Containers;
using DarkTech.DarkAL;
using DarkTech.Engine.Scripting;
using DarkTech.Engine.Timing;

namespace DarkTech.Engine.Sound
{
    internal sealed class OpenALBackEnd
    {
        private readonly Thread soundThread;
        private readonly AutoResetEvent initEvent;
        private readonly AutoResetEvent startEvent;
        private readonly OpenALDevice device;
        private readonly MixingSystem mixingSystem;
        private readonly CvarBool snd_shutdownRequested;
        private readonly IQueue<SoundCommand> frontBuffer;
        private readonly IQueue<SoundCommand> backBuffer;
        private readonly object syncRoot;
        private volatile bool initialized;
        private ITimer timer;

        internal OpenALBackEnd()
        {
            this.soundThread = new Thread(SoundThread);
            this.soundThread.Name = "Sound mixing";
            this.initEvent = new AutoResetEvent(false);
            this.startEvent = new AutoResetEvent(false);
            this.device = new OpenALDevice();
            this.mixingSystem = new MixingSystem();
            this.snd_shutdownRequested = Engine.ScriptingInterface.GetCvar<CvarBool>("snd_shutdownRequested");
            this.frontBuffer = new ArrayQueue<SoundCommand>(32);
            this.backBuffer = new ArrayQueue<SoundCommand>(32);
            this.syncRoot = new object();
            this.initialized = false;
            this.timer = null;
        }

        #region Front-end calls
        public bool Initialize()
        {
            // Start the sound thread.
            soundThread.Start();

            // Wait for the sound thread to complete initializing.
            initEvent.WaitOne();

            return initialized;
        }

        public void Start()
        {
            // Signal the back-end to start processing.
            startEvent.Set();
        }

        public void Restart()
        {
            // Request the sound thread to shut down.
            snd_shutdownRequested.Value = true;

            // Wait for the sound thread to shut down.
            soundThread.Join();

            // Attempt to initialize the sound system.
            if (Initialize())
            {
                // Signal the back-end to start processing.
                Start();
            }
        }

        public void AddCommand(SoundCommand command)
        {
            lock (syncRoot)
            {
                frontBuffer.Enqueue(command);
            }
        }

        public void Dispose()
        {
            initEvent.Dispose();
            startEvent.Dispose();
        }
        #endregion

        #region Sound-thread
        private void SoundThread()
        {
            Engine.Print("Creating OpenAL sound system");

            // Attempt to initialize the back-end.
            initialized = InitializeLocal();

            // Signal the front-end the back-end has completed initializing.
            initEvent.Set();

            // Exit out of the method if the initialization failed to prevent blocking the thread indefinitely on the startEvent.
            if (!initialized)
            {
                return;
            }

            // Wait until the front-end signals to start mixing.
            startEvent.WaitOne();

            // Enter the main mixing loop on the current (soundThread) thread.
            EnterMixingLoop();

            // Once the mixing loop has stopped perform cleanup.
            Shutdown();
        }

        private bool InitializeLocal()
        {
            // Create sound device.
            if (!device.Create())
            {
                return false;
            }

            // Create timer.
            timer = SystemFactory.CreateTimer();

            if (!timer.Initialize())
            {
                Engine.Error("Sound system timer failed to initialize");

                return false;
            }

            return true;
        }

        private void EnterMixingLoop()
        {
            // Retrieve the sound system/device frequency (44.1khz only for now) and the amount of samples per buffer.
            int snd_freq = Engine.ScriptingInterface.GetCvarValue<int>("snd_freq");
            int snd_bufferSize = Engine.ScriptingInterface.GetCvarValue<int>("snd_bufferSize");

            // Time step is the amount of time (in seconds) required to process one buffer (of snd_bufferSize samples).
            float timeStep = (float)snd_bufferSize / (float)snd_bufferSize;
            float accumelator = 0.0f;
            timer.Split();

            // Keep processing until either an engine or a sound system shutdown is requested.
            while (!Engine.ShutdownRequested && !snd_shutdownRequested)
            {
                timer.Split();

                accumelator += timer.ElapsedTime;

                while (accumelator >= timeStep)
                {
                    // Copy frontBuffer to the backBuffer.
                    lock (syncRoot)
                    {
                        while (frontBuffer.Count != 0)
                        {
                            backBuffer.Enqueue(frontBuffer.Dequeue());
                        }

                        // Reset the enqueue/dequeue positions.
                        frontBuffer.Clear();
                    }

                    // Process an entire buffer (snd_bufferSize samples).
                    mixingSystem.Process(backBuffer, snd_bufferSize);

                    // Reset the enqueue/dequeue positions.
                    backBuffer.Clear();

                    accumelator -= timeStep;
                }
            }

            // Reset the snd_shutdownRequested value.
            snd_shutdownRequested.Value = false;
        }

        private void Shutdown()
        {
            Engine.Print("Closing OpenAL sound system");

            // Destroy sound device.
            device.Destroy();

            // Dispose timer
            if (timer != null)
            {
                timer.Dispose();
            }
        }
        #endregion
    }
}
