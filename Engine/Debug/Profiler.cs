using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using DarkTech.Common.IO;
using DarkTech.Engine.Timing;

namespace DarkTech.Engine.Debug
{
    public class Profiler : IDisposable
    {
        private readonly ITimer timer;
        private readonly Stack<ActiveSection> activeSections;
        private readonly List<FrameResult> frameResults;
        private uint currentFrame;
        private bool beganFrame;
        private bool disposed;

        public FrameResult LastFrame { get { return GetResult(frameResults.Count - 1); } }
        public List<FrameResult> FrameResults { get { return frameResults; } }

        public Profiler()
        {
            this.timer = Platform.CreateTimer();
            this.activeSections = new Stack<ActiveSection>();
            this.frameResults = new List<FrameResult>();
            this.currentFrame = 0;
            this.beganFrame = false;
            this.disposed = false;
        }

        ~Profiler()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                timer.Dispose();

                disposed = true;
            }
        }

        public void ClearResults()
        {
            if (beganFrame)
                throw new InvalidOperationException("Cannot clear results while profiling a frame");

            frameResults.Clear();
        }

        public void ResetFrameCount()
        {
            if(beganFrame)
                throw new InvalidOperationException("Cannot reset frame count while profiling a frame");

            currentFrame = 0;
        }

        public void BeginFrame()
        {
            if (beganFrame)
                throw new InvalidOperationException("Already began frame");

            frameResults.Add(new FrameResult(currentFrame));
            beganFrame = true;
        }

        public void EndFrame()
        {
            if (!beganFrame)
                throw new InvalidOperationException("Must begin frame first");
            if (activeSections.Count != 0)
                throw new InvalidOperationException("Cannot end frame before all active sections have ended");

            // Last element is the active frame.
            frameResults[frameResults.Count - 1].ComputeResults();
            activeSections.Clear();
            currentFrame++;
            beganFrame = false;
        }

        public void Begin(string section)
        {
            long currentTick = timer.CurrentTick();
            ActiveSection parent = activeSections.Count == 0 ? null : activeSections.Peek();
            ActiveSection newSection = new ActiveSection(section, currentTick, parent);
            
            activeSections.Push(newSection);
        }

        public void End(string section)
        {
            if (activeSections.Count == 0)
                throw new InvalidOperationException("No active sections");
            if (activeSections.Peek().Name != section)
                throw new ArgumentException("Section begin/end mismatch", "section");

            ActiveSection activeSection = activeSections.Pop();
            long endTick = timer.CurrentTick();
            long duration = endTick - activeSection.StartTick;
            SectionResult result = new SectionResult(section, duration);

            if (activeSection.Children.Count != 0)
            {
                foreach (SectionResult childResult in activeSection.Children)
                {
                    childResult.Parent = result;
                    result.Children.Add(childResult);
                }
            }

            if (activeSection.Parent == null)
            {
                // Last element is the active frame.
                frameResults[frameResults.Count - 1].Sections.Add(result);
            }
            else
            {
                activeSection.Parent.Children.Add(result);
            }
        }

        public FrameResult GetResult(int frame)
        {
            if (frame < 0 || frame >= frameResults.Count)
                throw new ArgumentOutOfRangeException("frame");

            return frameResults[frame];
        }

        private sealed class ActiveSection
        {
            public string Name { get; private set; }
            public long StartTick { get; private set; }
            public ActiveSection Parent { get; private set; }
            public List<SectionResult> Children { get; private set; }

            public ActiveSection(string name, long startTick, ActiveSection parent)
            {
                this.Name = name;
                this.StartTick = startTick;
                this.Parent = parent;
                this.Children = new List<SectionResult>();
            }
        }
    }

    public sealed class FrameResult
    {
        public uint FrameIndex { get; private set; }
        public long TotalDuration { get; private set; }
        public List<SectionResult> Sections { get; private set; }

        internal FrameResult(uint frameIndex)
        {
            this.FrameIndex = frameIndex;
            this.TotalDuration = 0;
            this.Sections = new List<SectionResult>();
        }

        private FrameResult(uint frameIndex, long totalDuration)
        {
            this.FrameIndex = frameIndex;
            this.TotalDuration = totalDuration;
            this.Sections = new List<SectionResult>();
        }

        internal void ComputeResults()
        {
            // Compute total duration.
            foreach (SectionResult section in Sections)
            {
                TotalDuration += section.Duration;
            }

            // Compute fractions.
            foreach (SectionResult section in Sections)
            {
                ComputeSection(section, TotalDuration);
            }
        }

        private void ComputeSection(SectionResult section, long parentDuration)
        {
            section.TotalFraction = (float)((double)section.Duration / (double)TotalDuration);
            section.SiblingFraction = (float)((double)section.Duration / (double)parentDuration);

            foreach (SectionResult childResult in section.Children)
            {
                ComputeSection(childResult, section.Duration);
            }
        }

        public void Serialize(DataStream stream)
        {
            stream.WriteUInt(FrameIndex);
            stream.WriteLong(TotalDuration);
            stream.WriteUShort((ushort)Sections.Count);

            foreach (SectionResult section in Sections)
            {
                section.Serialize(stream);
            }
        }

        public static FrameResult Deserialize(DataStream stream)
        {
            uint frameIndex = stream.ReadUInt();
            long totalDuration = stream.ReadLong();
            int sectionCount = stream.ReadUShort();

            FrameResult result = new FrameResult(frameIndex, totalDuration);

            for (int i = 0; i < sectionCount; i++)
            {
                SectionResult section = SectionResult.Deserialize(stream);

                result.Sections.Add(section);
            }

            return result;
        }
    }

    public sealed class SectionResult
    {
        public string Name { get; private set; }
        public long Duration { get; private set; }
        public float SiblingFraction { get; internal set; }
        public float TotalFraction { get; internal set; }
        public SectionResult Parent { get; internal set; }
        public List<SectionResult> Children { get; private set; }

        internal SectionResult(string name, long duration)
        {
            this.Name = name;
            this.Duration = duration;
            this.SiblingFraction = 0f;
            this.TotalFraction = 0f;
            this.Parent = null;
            this.Children = new List<SectionResult>();
        }

        private SectionResult(string name, long duration, float siblingFraction, float totalFraction, SectionResult parent)
        {
            this.Name = name;
            this.Duration = duration;
            this.SiblingFraction = siblingFraction;
            this.TotalFraction = totalFraction;
            this.Parent = parent;
            this.Children = new List<SectionResult>();
        }

        public void Serialize(DataStream stream)
        {
            byte[] nameBuffer = Encoding.UTF8.GetBytes(Name);

            stream.WriteUShort((ushort)nameBuffer.Length);
            stream.Write(nameBuffer);
            stream.WriteLong(Duration);
            stream.WriteFloat(SiblingFraction);
            stream.WriteFloat(TotalFraction);
            stream.WriteUShort((ushort)Children.Count);

            foreach (SectionResult child in Children)
            {
                child.Serialize(stream);
            }
        }

        public static SectionResult Deserialize(DataStream stream, SectionResult parent = null)
        {
            int nameLength = stream.ReadUShort();
            byte[] nameBuffer = stream.ReadBytes(nameLength);
            string name = Encoding.UTF8.GetString(nameBuffer, 0, nameLength);
            long duration = stream.ReadLong();
            float silblingFraction = stream.ReadFloat();
            float totalFraction = stream.ReadFloat();

            SectionResult result = new SectionResult(name, duration, silblingFraction, totalFraction, parent);

            int childCount = stream.ReadUShort();

            for (int i = 0; i < childCount; i++)
            {
                SectionResult child = Deserialize(stream, result);

                result.Children.Add(child);
            }

            return result;
        }
    }
}
