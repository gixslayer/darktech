using System;

using DarkTech.DarkAL;

namespace DarkTech.Engine.Sound
{
    internal sealed class OpenALDevice
    {
        private IntPtr hDevice;
        private IntPtr hContext;

        internal OpenALDevice()
        {
            this.hDevice = IntPtr.Zero;
            this.hContext = IntPtr.Zero;
        }

        public bool Create()
        {
            Engine.Print("Creating sound device");

            // Get the device name, passing null to alcOpenDevice will open the default device.
            string snd_device = Engine.ScriptingInterface.GetCvarValue<string>("snd_device");
            string deviceName = snd_device == "default" ? null : snd_device;

            // Open the device specified by snd_device.
            hDevice = alc.OpenDevice(deviceName);

            if (hDevice == IntPtr.Zero)
            {
                Engine.Errorf("alcOpenDevice failed for device: {0}", snd_device);

                return false;
            }

            Engine.Printf("Using device: {0}", snd_device);
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

            Engine.Print("Sound device created");

            return true;
        }

        public void Destroy()
        {
            Engine.Print("Destroying sound device");

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
    }
}
