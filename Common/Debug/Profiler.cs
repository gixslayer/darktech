using System;
using System.Collections.Generic;

namespace DarkTech.Common.Debug
{
    /// <summary>
    /// Provides a basic profiling solution to measure executing time for code sections.
    /// </summary>
    public static class Profiler
    {
        private static readonly Dictionary<string, DateTime> ACTIVE_SECTIONS = new Dictionary<string, DateTime>();
        private static readonly Dictionary<string, TimeSpan> COMPLETED_SECTIONS = new Dictionary<string, TimeSpan>();
        private static readonly TimeSpan TIMESPAN_ONE_TICK = new TimeSpan(1);

        private static TimeSpan total = TimeSpan.Zero;

        /// <summary>
        /// The total time spend profiling.
        /// </summary>
        public static TimeSpan Total { get { return total; } }
        /// <summary>
        /// The collection of sections that have information available.
        /// </summary>
        public static Dictionary<string, TimeSpan>.KeyCollection Sections { get { return COMPLETED_SECTIONS.Keys; } }

        /// <summary>
        /// Begins profiling a new section.
        /// </summary>
        /// <param name="section">The name of the section.</param>
        /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="section"/> has not ended.</exception>
        public static void Begin(string section)
        {
            if (ACTIVE_SECTIONS.ContainsKey(section))
                throw new InvalidOperationException("Section " + section + " has not ended");

            ACTIVE_SECTIONS.Add(section, DateTime.Now);
        }

        /// <summary>
        /// Ends profiling a section and returns the total time spend for that section.
        /// </summary>
        /// <param name="section">The name of the section.</param>
        /// <returns>Returns a <c>TimeSpan</c> with the total time spend in the <paramref name="section"/>.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="section"/> has not been started.</exception>
        /// <remarks>
        /// When previous information is found for the <paramref name="section"/> the new information is added to that information.
        /// The time spend is guaranteed to be at least one tick.
        /// </remarks>
        public static TimeSpan End(string section)
        {
            if (!ACTIVE_SECTIONS.ContainsKey(section))
                throw new InvalidOperationException("Section " + section + " has not been started");

            // Calculate the time spend on the section.
            DateTime end = DateTime.Now;
            DateTime start = ACTIVE_SECTIONS[section];
            TimeSpan duration = end.Subtract(start);

            // Ensure the duration is at least one tick.
            if (duration.Ticks == 0)
            {
                duration = TIMESPAN_ONE_TICK;
            }

            // Add the time to the existing entry or create a new entry if it does not exist.
            if (COMPLETED_SECTIONS.ContainsKey(section))
            {
                COMPLETED_SECTIONS[section] += duration;
            }
            else
            {
                COMPLETED_SECTIONS.Add(section, duration);
            }
            
            // Increase the total time.
            total.Add(duration);

            return COMPLETED_SECTIONS[section];
        }

        /// <summary>
        /// Resets the <see cref="Profiler"/> by clearing all previous information and setting the total time to zero.
        /// </summary>
        public static void Reset()
        {
            ACTIVE_SECTIONS.Clear();
            COMPLETED_SECTIONS.Clear();

            total = TimeSpan.Zero;
        }

        /// <summary>
        /// Returns a <c>TimeSpan</c> with the total time spend in the <paramref name="section"/>.
        /// </summary>
        /// <param name="section">The name of the section.</param>
        /// <returns>Returns a <c>TimeSpan</c> with the total time spend in the <paramref name="section"/>.</returns>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="section"/> has no information available.</exception>
        public static TimeSpan Get(string section)
        {
            if (!Has(section))
                throw new ArgumentException("Profiler does not contain information for section " + section);

            return COMPLETED_SECTIONS[section];
        }

        /// <summary>
        /// Returns a <c>double</c> in the range of [0.0, 1.0] with the fraction of the total time spend in the <paramref name="section"/>.
        /// </summary>
        /// <param name="section">The name of the section.</param>
        /// <returns>Returns a <c>double</c> in the range of [0.0, 1.0] with the fraction of the total time spend in the <paramref name="section"/>.</returns>
        /// <exception cref="ArgumentException">Thrown when the specified <paramref name="section"/> has no information available.</exception>
        public static double GetFraction(string section)
        {
            if (!Has(section))
                throw new ArgumentException("Profiler does not contain information for section " + section);

            TimeSpan sectionTime = COMPLETED_SECTIONS[section];

            return (double)sectionTime.Ticks / (double)total.Ticks;
        }

        /// <summary>
        /// Checks if the specified <paramref name="section"/> has information available.
        /// </summary>
        /// <param name="section">The name of the section.</param>
        /// <returns>Returns <c>true</c> if the specified <paramref name="section"/> has information available, otherwise <c>false</c> is returned.</returns>
        public static bool Has(string section)
        {
            return COMPLETED_SECTIONS.ContainsKey(section);
        }
    }
}
