using System;

namespace DarkTech.Engine.Scripting
{
    public abstract class CvarBounded<T> : CvarBase<T> where T : IComparable<T>
    {
        public T MinValue { get; private set; }
        public T MaxValue { get; private set; }

        internal CvarBounded(string name, string description, CvarFlag flags, T defaultValue, T minValue, T maxValue)
            : base(name, description, flags, defaultValue)
        {
            this.MinValue = minValue;
            this.MaxValue = maxValue;
        }

        protected override bool IsValidValue(T value)
        {
            if (MinValue != null)
            {
                if (MinValue.CompareTo(value) > 0)
                {
                    return false;
                }
            }

            if (MaxValue != null)
            {
                if (MaxValue.CompareTo(value) < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
