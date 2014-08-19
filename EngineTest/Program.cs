using System;
//using System.Collections.Generic;
using System.Drawing;
using System.IO;

using DarkTech.Common.Containers;

//using DarkTech.Common.Math.Noise;
using DarkTech.DarkAL;
//using DarkTech.Engine;
using DarkTech.DarkGL;

using DarkTech.WindowLib;

namespace EngineTest
{
    class Program
    {
        static bool pumpevents = true;
        static Window window;
        static Context context;

        static void Main(string[] args)
        {
            //TestProfiler();

            Console.WriteLine("pre start");

           /* EngineConfiguration config = new EngineConfiguration();
            config.NetModel = NetModel.Local;
            config.RootDirectory = @"D:\Programming\C#\DarkTech\EngineTest\bin\Debug";
            config.ClientDLL = "TestClient.dll";
            config.ServerDLL = "TestServer.dll";*/

           // Console.WriteLine(Engine.Start(config));

            WindowConfiguration config = new WindowConfiguration();

            config.ClassName = "TESTCLASS";
            config.Height = 768;
            config.Width = 1024;
            config.X = 0;
            config.Y = 0;
            config.Title = "Test Window";
            config.Mode = WindowMode.Windowed;

            IntPtr hInstance = System.Diagnostics.Process.GetCurrentProcess().Handle;

            window = Window.CreateWindow(hInstance, config);

            window.Created += window_Created;
            window.Destroyed += window_Destroyed;
            window.Moved += window_Moved;
            window.Resized += window_Resized;
            window.Destroying += window_Destroying;
            window.KeyUp += window_KeyUp;
            window.KeyDown += window_KeyDown;
            window.KeyPressed += window_KeyPressed;
        //    window.MouseWheelMoved += window_MouseWheelMoved;
         //   window.MouseDown += window_MouseDown;
         //   window.MouseUp += window_MouseUp;
          //  window.MouseMoved += window_MouseMoved;

            window.Create();
            window.Show();
            window.RegisterInputDevice();

            Console.WriteLine("Creating GL context");

            try
            {
                context = Context.CreateContext(window.Handle);

                int[] result = new int[1];
                gl.GetIntegerv(GL.MAJOR_VERSION, result);
                Console.WriteLine("OpenGL Major = {0}", result[0]);
                gl.GetIntegerv(GL.MINOR_VERSION, result);
                Console.WriteLine("OpenGL Minor = {0}", result[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed: {0}", e.Message);
            }

            gl.ClearColor(1f, 0f, 0f, 0f);
            wgl.SwapInterval(1); // vsync

            while (pumpevents)
            {
                window.ProcessEvents();

                gl.Clear(GL.COLOR_BUFFER_BIT);

                context.SwapBuffers();

                System.Threading.Thread.Sleep(33);
            }

            window.Destroy();
            context.Dispose();

            Console.WriteLine("post start");

            Console.Read();

            #region Hide
            //Render(0x1337243, 32, 1024, 128, "out.jpg");
            //Render(0x1337242, 128, 1024, 128, "out2.jpg");

           /* int size = 2048;
            int seed = 0x1336;
            int octaves = 8;
            float persistance = 0.5f;
            float amplitude = 1.0f;
            float totalAmplitude = 0.0f;

            float[][] noise = NoiseMap(size, seed);
            float[][][] smoothed = new float[octaves][][];
            float[][] perlin = new float[size][];

            Save(noise, Color.Black, Color.White, "noise.jpg");

            smoothed[0] = noise;

            for (int i = 1; i < 8; i++)
            {
                float[][] smooth = Smooth(noise, i);

                smoothed[i] = smooth;

               // Save(smooth, Color.Black, Color.White, string.Format("smooth{0}.jpg", i));
            }

            for (int i = 0; i < size; i++)
            {
                perlin[i] = new float[size];
            }

            for (int octave = octaves - 1; octave >= 0; octave--)
            {
                amplitude *= persistance;
                totalAmplitude += amplitude;

                for (int x = 0; x < size; x++)
                {
                    for (int y = 0; y < size; y++)
                    {
                        perlin[x][y] += smoothed[octave][x][y] * amplitude;
                    }
                }
            }

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    perlin[x][y] /= totalAmplitude;
                }
            }

            Save(perlin, Color.Black, Color.White, "perlin.jpg");*/

            /*Console.WriteLine("Capture devices");
            foreach (string captureDevice in ALUtils.GetCaptureDevices())
            {
                Console.WriteLine(captureDevice);
            }

            Console.WriteLine("Playback devices");
            string deviceName = string.Empty;

            foreach (string playbackDevice in ALUtils.GetPlaybackDevices())
            {
                deviceName = playbackDevice;

                Console.WriteLine(playbackDevice);
            }

            IntPtr device = alc.OpenDevice(deviceName);
            IntPtr context = alc.CreateContext(device, IntPtr.Zero);
            alc.MakeContextCurrent(context);

            int error = alc.GetError(device);

            Console.WriteLine("ERROR: {0} ({1})", error != ALC.NO_ERROR, error);

            Console.WriteLine(alc.GetCurrentContext() == context);

            alc.DestroyContext(context);
            alc.CloseDevice(device);*/

            //Console.WriteLine("DONE");
            //Console.Read();
            #endregion
        }

        static void window_MouseMoved(int x, int y)
        {
            Console.WriteLine("Mouse moved: {0},{1}", x, y);
        }

        static void window_MouseUp(int mouseButton)
        {
            Console.WriteLine("Mouse up: {0}", mouseButton);
        }

        static void window_MouseDown(int mouseButton)
        {
            Console.WriteLine("Mouse down: {0}", mouseButton);
        }

        static void window_MouseWheelMoved(int delta)
        {
            Console.WriteLine("Mouse wheel: {0}", delta);
        }

        static void window_KeyPressed(int keyCode)
        {
            Console.WriteLine("Pressed: {0}", keyCode);
        }

        static void window_KeyDown(int keyCode)
        {
            Console.WriteLine("Key down: {0}", keyCode);
        }

        static void window_KeyUp(int keyCode)
        {
            Console.WriteLine("Key up: {0}", keyCode);

            // ESCAPE
            if (keyCode == 27)
            {
                window.Destroy();
            }
        }

        static void window_Destroying()
        {
            Console.WriteLine("Destroying");
        }

        static void window_Resized(int width, int height)
        {
            Console.WriteLine("Resized: {0}x{1}", width, height);
        }

        static void window_Moved(int x, int y)
        {
            Console.WriteLine("Moved: {0},{1}", x, y);
        }

        static void window_Destroyed()
        {
            Console.WriteLine("Destroyed");

            pumpevents = false;
        }

        static void window_Created()
        {
            Console.WriteLine("Created");
        }

        #region Hide
        
        /*static void Render(int seed, int sampleSize, int width, int height, string dest)
        {
            Bitmap bmp = new Bitmap(width, height);
            NoiseGenerator noiseGen = new ValueNoiseGenerator(seed, sampleSize);
            InterpolatedNoise interp = new InterpolatedNoise(noiseGen);
            FractalNoise frac = new FractalNoise(interp, .35f, 16, sampleSize);
            Color backgroundColor = Color.White;
            Pen foregroundColor = Pens.Black;

            Graphics g = Graphics.FromImage(bmp);

            g.Clear(backgroundColor);

            float[] map = new float[bmp.Width];

            for (int x = 0; x < bmp.Width; x++)
            {
                float xScaled = (float)x / (float)bmp.Width * (float)(sampleSize - 1);
                float yRaw = frac.Generate(xScaled);

                map[x] = yRaw;
            }

            // Normalize map
            float max = 0.0f;

            foreach (float f in map)
            {
                if (f > max)
                    max = f;
            }

            if (max != 0.0f)
            {
                for (int i = 0; i < map.Length; i++)
                {
                    map[i] = map[i] / max;
                }
            }

            for (int x = 0; x < bmp.Width - 1; x++)
            {
                int y1 = (int)(map[x] * (bmp.Height - 1));
                int y2 = (int)(map[x + 1] * (bmp.Height - 1));

                g.DrawLine(foregroundColor, x, y1, x + 1, y2);
            }

                /*    int y = (int)(yRaw * (bmp.Height - 1));

                    float xScaled2 = (float)(x + 1) / (float)bmp.Width * (float)(sampleSize - 1);
                    float yRaw2 = frac.Generate(xScaled2);
                    int y2 = (int)(yRaw2 * (bmp.Height - 1));

                    g.DrawLine(foregroundColor, x, y, x + 1, y2);
                }* /

            g.Dispose();

            bmp.Save(dest);
            bmp.Dispose();
        }*/

        static float[][] NoiseMap(int size, int seed)
        {
            Random random = new Random(seed);
            float[][] result = new float[size][];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new float[size];
            }

            for (int h = 0; h < size; h++)
            {
                for (int w = 0; w < size; w++)
                {
                    result[w][h] = (float)random.NextDouble();
                }
            }

                return result;
        }

        static float[][] Smooth(float[][] noise, int octave)
        {
            float[][] result = new float[noise.Length][];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new float[noise[i].Length];
            }

            int period = 1 << octave;
            float frequency = 1.0f / period;

            Console.WriteLine("Octave:      {0}", octave);
            Console.WriteLine("Period:      {0}", period);
            Console.WriteLine("Frequency:   {0}", frequency);

            for (int x = 0; x < noise.Length; x++)
            {
                int x1 = (x / period) * period;
                int x2 = (x1 + period) % noise.Length;
                float hBlend = (x - x1) * frequency;

                for (int y = 0; y < noise[x].Length; y++)
                {
                    int y1 = (y / period) * period;
                    int y2 = (y1 + period) % noise[x].Length;
                    float vBlend = (y - y1) * frequency;

                    float top = Lerp(noise[x1][y1], noise[x2][y1], hBlend);
                    float bottom = Lerp(noise[x1][y2], noise[x2][y2], hBlend);

                    result[x][y] = Lerp(top, bottom, vBlend);
                }
            }

            return result;
        }

        static float Lerp(float x, float y, float r)
        {
            float ft = (1.0f - (float)Math.Cos(r * Math.PI)) * 0.5f;

            return x * (1.0f - ft) + y * ft;

            //return x * (1.0f - r) + y * r;
        }

        static void Save(float[][] data, Color gradStart, Color gradEnd, string path)
        {
            Bitmap bmp = new Bitmap(data.Length, data[0].Length);

            for (int x = 0; x < data.Length; x++)
            {
                for (int y = 0; y < data[x].Length; y++)
                {
                    bmp.SetPixel(x, y, Gradiant(gradStart, gradEnd, data[x][y]));
                }
            }

            bmp.Save(path);
            bmp.Dispose();
        }

        static Color Gradiant(Color start, Color end, float f)
        {
            int r = (int)(start.R * (1.0f - f) + end.R * f);
            int g = (int)(start.G * (1.0f - f) + end.G * f);
            int b = (int)(start.B * (1.0f - f) + end.B * f);

            return Color.FromArgb(255, r, g, b);
        }
        #endregion
    }
}
