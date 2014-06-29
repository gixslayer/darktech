using System;
using System.Collections.Generic;
using System.Threading;

using DarkTech.Engine.Scripting;
using DarkTech.Engine.Timing;

using DarkTech.DarkAL;

namespace DarkTech.Engine.Sound
{
    internal sealed class OpenALSoundSystem : ISoundSystem
    {
        private readonly ManualResetEventSlim initializeSync;
        private readonly ManualResetEventSlim startSync;
        private readonly Thread soundThread;
        private readonly CvarString snd_device;
        private readonly CvarBool snd_shutdownRequested;
        private readonly List<ISampleProvider> sampleProviders;
        private Mixer mixer;
        private volatile bool initialized;
        private IntPtr hContext;
        private IntPtr hDevice;

        public OpenALSoundSystem()
        {
            this.initializeSync = new ManualResetEventSlim(false);
            this.startSync = new ManualResetEventSlim(false);
            this.soundThread = new Thread(SoundThread);
            this.soundThread.Name = "Sound system";
            this.snd_device = Engine.ScriptingInterface.GetCvar<CvarString>("snd_device");
            this.snd_shutdownRequested = Engine.ScriptingInterface.GetCvar<CvarBool>("snd_shutdownRequested");
            this.sampleProviders = new List<ISampleProvider>();
            this.hContext = IntPtr.Zero;
            this.hDevice = IntPtr.Zero;
        }

        public bool Initialize()
        {
            // Reset the wait handles.
            initializeSync.Reset();
            startSync.Reset();

            // Start the sound thread.
            soundThread.Start();

            // Block until the sound thread has finished initializing.
            initializeSync.Wait();

            // The value of initialized will be set in the sound thread.
            return initialized;
        }

        public void Start()
        {
            // Signal the sound thread to begin processing.
            startSync.Set();
        }

        public void Restart()
        {
            // Force the sound thread to exit.
            snd_shutdownRequested.Value = true;
            soundThread.Join();

            // Initialize the sound system.
            if (Initialize())
            {
                // Start the sound system.
                Start();
            }
        }

        public void Dispose()
        {
            Engine.Print("Closing OpenAL sound system");

            // Check if a valid context handle exists.
            if (hContext != IntPtr.Zero)
            {
                // Set the current context to null (none).
                if (alc.MakeContextCurrent(IntPtr.Zero))
                {
                    // Destroy the context.
                    alc.DestroyContext(hContext);

                    Engine.PrintDebugf("alcDestroyContext: {0}", hContext.ToString());

                    hContext = IntPtr.Zero;
                }
                else
                {
                    Engine.Error("alcMakeContextCurrent(null) failed");
                }
            }

            // Check if a valid device handle exists.
            if (hDevice != IntPtr.Zero)
            {
                // Close the device.
                if (alc.CloseDevice(hDevice))
                {
                    Engine.PrintDebugf("alcCloseDevice: {0}", hDevice.ToString());

                    hDevice = IntPtr.Zero;
                }
                else
                {
                    Engine.Error("alcCloseDevice failed");
                }
            }
        }

        private void SoundThread()
        {
            // If the initialization failed exit out of the thread so it won't block indefinitely.
            if (!InitializeLocal())
            {
                Engine.Error("Failed to initialize OpenAL sound system");

                return;
            }

            // Initialization successful, block the sound thread until the startup thread signals to start processing.
            startSync.Wait();

            // Begin processing.
            EnterProcessLoop();
        }

        private bool InitializeLocal()
        {
            Engine.Print("Initializing OpenAL sound system");

            // Attempt to initialize OpenAL.
            initialized = InitializeOpenAL();

            // Initialize the mixer.
            int channelCount = Engine.ScriptingInterface.GetCvarValue<int>("snd_mixerChannels");
            mixer = new Mixer(channelCount);

            // Set the master properties.
            mixer.Master.Gain = Engine.ScriptingInterface.GetCvarValue<float>("snd_volume");
            mixer.Master.Balance = Engine.ScriptingInterface.GetCvarValue<float>("snd_balance");
            mixer.Master.Output = new OpenALVoice();

            // Set all channel properties.
            for (int i = 0; i < channelCount; i++)
            {
                mixer[i].Name = Engine.ScriptingInterface.GetCvarValue<string>(string.Format("snd_channel{0}_name", i));
                mixer[i].Gain = Engine.ScriptingInterface.GetCvarValue<float>(string.Format("snd_channel{0}_gain", i));
                mixer[i].Balance = Engine.ScriptingInterface.GetCvarValue<float>(string.Format("snd_channel{0}_balance", i));

                int destChannelIndex = Engine.ScriptingInterface.GetCvarValue<int>(string.Format("snd_channel{0}_dest", i));

                // Cannot route to itself as that would cause an infinite loop.
                if (destChannelIndex == i)
                {
                    Engine.Errorf("Invalid sound channel dest ({0}) on channel {1}: Cannot output to itself", destChannelIndex, i);

                    destChannelIndex = -1;
                }

                // Validate the channel actually exists.
                if (destChannelIndex >= channelCount)
                {
                    Engine.Errorf("Invalid sound channel dest ({0}) on channel {1}: Dest channel does not exist", destChannelIndex, i);

                    destChannelIndex = -1;
                }

                mixer[i].Output = destChannelIndex == -1 ? mixer.Master : mixer[destChannelIndex];
            }

            // Signal the startup thread that the initialization is completed.
            initializeSync.Set();

            return initialized;
        }

        private bool InitializeOpenAL()
        {
            // Get the device name, passing null to alcOpenDevice will open the default device.
            string deviceName = snd_device.Value == "default" ? null : snd_device.Value;

            // Open the device specified by snd_device.
            hDevice = alc.OpenDevice(deviceName);

            if (hDevice == IntPtr.Zero)
            {
                Engine.Errorf("alcOpenDevice failed for device: {0}", snd_device.Value);

                return false;
            }

            Engine.PrintDebugf("Using device: {0}", snd_device.Value);
            Engine.PrintDebugf("Device handle: {0}", hDevice.ToString());

            // Create a context on the opened device.
            hContext = alc.CreateContext(hDevice, IntPtr.Zero);

            if (hContext == IntPtr.Zero)
            {
                Engine.Error("alcCreateContext failed");

                // Context creation failed, close the device.
                alc.CloseDevice(hDevice);

                // Set the device handle to null so it wont be closed again during disposal.
                hDevice = IntPtr.Zero;

                return false;
            }

            Engine.PrintDebugf("Context handle: {0}", hContext.ToString());

            // Make the created context current.
            if (!alc.MakeContextCurrent(hContext))
            {
                Engine.Error("alcMakeContextCurrent failed");

                // Failed to make context current, destroy context and close device.
                alc.DestroyContext(hContext);
                alc.CloseDevice(hDevice);

                // Set the device and context handle to null so they wont be closed/destroyed again during disposal.
                hContext = IntPtr.Zero;
                hDevice = IntPtr.Zero;

                return false;
            }

            return true;
        }

        private void EnterProcessLoop()
        {
            ITimer timer = SystemFactory.CreateTimer();
            float frequency = Engine.ScriptingInterface.GetCvarValue<int>("snd_freq");
            float bufferSize = Engine.ScriptingInterface.GetCvarValue<int>("snd_bufferSize");
            float unproccessedTime = 0.0f;
            float stepSize = bufferSize / frequency;
            float sampleDuration = 1000f / frequency;
            snd_shutdownRequested.Value = false;

            // Initialize the timer.
            if (!timer.Initialize())
            {
                Engine.Error("Failed to initialize sound system timer");

                // Timer failed to initialize, request a sound system shutdown to prevent processing.
                snd_shutdownRequested.Value = true;
            }

            // Main processing loop, will continue to run until an engine shutdown or sound system shutdown is requested.
            while (!Engine.ShutdownRequested && !snd_shutdownRequested.Value)
            {
                timer.Split();

                unproccessedTime += timer.ElapsedTime;

                while (unproccessedTime >= stepSize)
                {
                    int samplesToProcess = 0;

                    while (unproccessedTime >= sampleDuration)
                    {
                        samplesToProcess++;
                        unproccessedTime -= sampleDuration;
                    }

                    Process(samplesToProcess);
                }
            }

            // Shut down sound system.
            timer.Dispose();
            Dispose();
        }

        private void Process(int samplesToProcess)
        {
            for (int i = 0; i < samplesToProcess; i++)
            {
                foreach (ISampleProvider provider in sampleProviders)
                {
                    provider.Process();
                }

                mixer.Process();
            }
        }
    }
}
