using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

//using DarkTech.Common.Math.Noise;
using DarkTech.DarkAL;
using DarkTech.Engine;
using DarkTech.Engine.Debug;

namespace EngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestProfiler();

            Console.WriteLine("pre start");

            EngineConfiguration config = new EngineConfiguration();
            config.NetModel = NetModel.Local;
            config.RootDirectory = @"D:\Programming\C#\DarkTech\EngineTest\bin\Debug";
            config.ClientDLL = "TestClient.dll";
            config.ServerDLL = "TestServer.dll";

            Console.WriteLine(Engine.Start(config));

            Console.WriteLine("post start");

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
        }

        static void TestProfiler()
        {
            Profiler profiler = new Profiler();
            FileStream stream = new FileStream("frame.plog", FileMode.Create, FileAccess.Write);

            for (int i = 0; i < 10; i++)
            {
                profiler.BeginFrame();

                profiler.Begin("test1");
                {
                    profiler.Begin("test2");
                    {
                        profiler.Begin("test3");
                        {
                            System.Threading.Thread.Sleep(10);
                        }
                        profiler.End("test3");

                        profiler.Begin("test4");
                        {
                            System.Threading.Thread.Sleep(20);
                        }
                        profiler.End("test4");

                        profiler.Begin("test5");
                        {
                            System.Threading.Thread.Sleep(30);
                        }
                        profiler.End("test5");
                    }
                    profiler.End("test2");
                }
                profiler.End("test1");

                profiler.EndFrame();

                FrameResult frameResult = profiler.LastFrame;
                frameResult.Serialize(stream);
            }

            stream.Dispose();

            //FileStream dStream = new FileStream("frame.plog", FileMode.Open, FileAccess.Read);
            //FrameResult deserialized = FrameResult.Deserialize(dStream);
        }

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
    }
}
