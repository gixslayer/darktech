using System;

namespace DarkTech.Common.Utils
{
    public abstract class NumberGenerator<T>
    {
        private readonly T minValue;
        private readonly T maxValue;
        protected T next;

        public OverflowMode OverflowMode { get; set; }

        public NumberGenerator(T minValue, T maxValue, OverflowMode overflowMode)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.next = minValue;
            this.OverflowMode = overflowMode;
        }

        public T Next()
        {
            T current = next;

            if (next.Equals(maxValue))
            {
                // Handle overflow.
                switch (OverflowMode)
                {
                    case OverflowMode.Clamp:
                        // The next value remains MaxValue.
                        break;

                    case OverflowMode.ThrowException:
                        throw new OverflowException("Number generator overflow");

                    case OverflowMode.Wrap:
                        // Wrap the next value to MinValue.
                        next = minValue;
                        break;
                }
            }
            else
            {
                next = Increment(next);
            }

            return current;
        }

        protected abstract T Increment(T value);
    }
}
