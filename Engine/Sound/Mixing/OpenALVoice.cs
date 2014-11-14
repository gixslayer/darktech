using System;
using System.Collections.Generic;

using DarkTech.DarkAL;

namespace DarkTech.Engine.Sound.Mixing
{
    public sealed class OpenALVoice //: ISampleConsumer
    {
        private readonly SampleBuffer sampleBuffer;
        private readonly int bufferSize;
        private readonly int bufferCount;
        private readonly Queue<uint> bufferQueue;
        private readonly uint sid;

        public OpenALVoice()
        {
            this.sampleBuffer = new SampleBuffer();
            this.bufferSize = 441; // 441 samples = 10ms @ 44100Hz
            this.bufferCount = 1;
            this.bufferQueue = new Queue<uint>();

            al.GenBuffers(1, out sid);
        }

        public void Process()
        {
            int processedBufferCount;

            al.GetSourcei(sid, AL.BUFFERS_PROCESSED, out processedBufferCount);

            uint[] processedBuffers = new uint[processedBufferCount];

            al.SourceUnqueueBuffers(sid, processedBufferCount, processedBuffers);
            al.DeleteBuffers(processedBufferCount, processedBuffers);
        }

        public void Process(ref Sample sample)
        {
            sampleBuffer.Add(ref sample);

            if (sampleBuffer.Count == bufferSize)
            {
                uint bid;
                byte[] data = GetSampleData();

                sampleBuffer.Clear();

                al.GenBuffers(1, out bid);
                al.BufferData(bid, AL.FORMAT_STEREO16, data, data.Length, 44100);

                bufferQueue.Enqueue(bid);

                if (bufferQueue.Count >= bufferCount)
                {
                    int sourceState;

                    al.GetSourcei(sid, AL.SOURCE_STATE, out sourceState);

                    if (sourceState != AL.PLAYING)
                    {
                        al.SourcePlay(sid);
                    }
                }
            }
        }

        private unsafe byte[] GetSampleData()
        {
            byte[] result = new byte[sampleBuffer.Count * 4]; // 2 bytes per channel, 2 channels per sample = 4 bytes per sample.

            fixed (byte* ptrResult = result)
            {
                short* ptrData = (short*)ptrResult;

                for (int i = 0; i < sampleBuffer.Count; i++)
                {
                    Sample sample = sampleBuffer[i];

                    short leftChannel = Clamp(sample.left);
                    short rightChannel = Clamp(sample.right);

                    *(ptrData++) = leftChannel;
                    *(ptrData++) = rightChannel;
                }
            }

            return result;
        }

        private static short Clamp(float value)
        {
            if (value > short.MaxValue) return short.MaxValue;
            if (value < short.MinValue) return short.MinValue;

            return (short)value;
        }
    }
}
