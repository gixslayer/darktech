using System;
using System.Collections.Generic;

namespace DarkTech.Common.Debug
{
    public static class Profiler
    {
        private static readonly Dictionary<string, DateTime> sections = new Dictionary<string, DateTime>();
        private static readonly Dictionary<string, TimeSpan> results = new Dictionary<string, TimeSpan>();
        private static TimeSpan total = TimeSpan.Zero;

        public static TimeSpan Total { get { return total; } }
        public static Dictionary<string, TimeSpan>.KeyCollection Sections { get { return results.Keys; } }

        public static void Begin(string section)
        {
            if (sections.ContainsKey(section))
                throw new InvalidOperationException("Section " + section + " has not ended");

            if (results.ContainsKey(section))
            {
                results.Remove(section);
            }

            sections.Add(section, DateTime.Now);
        }

        public static TimeSpan End(string section)
        {
            if (!sections.ContainsKey(section))
                throw new InvalidOperationException("Section " + section + " has not been started");

            DateTime end = DateTime.Now;
            DateTime start = sections[section];

            TimeSpan difference = end.Subtract(start);

            results.Add(section, difference);
            total.Add(difference);

            return difference;
        }

        public static void Reset()
        {
            sections.Clear();
            results.Clear();

            total = TimeSpan.Zero;
        }

        public static TimeSpan Get(string section)
        {
            if (!Has(section))
                throw new ArgumentException("Profiler does not contain information for section " + section);

            return results[section];
        }

        public static float GetFraction(string section)
        {
            if (!Has(section))
                throw new ArgumentException("Profiler does not contain information for section " + section);

            // If the total time is under 1 tick the 'time spend' is distributed evenly across all sections.
            if (total.Ticks == 0)
            {
                return 1f / (float)results.Count;
            }

            TimeSpan sectionTime = results[section];

            return (float)((double)sectionTime.Ticks / (double)total.Ticks);
        }

        public static bool Has(string section)
        {
            return results.ContainsKey(section);
        }
    }
}
