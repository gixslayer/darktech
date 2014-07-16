namespace DarkTech.Common.Utils
{
    public sealed class SharedReference<T>
    {
        public T Value { get; private set; }

        public SharedReference(T value)
        {
            this.Value = value;
        }

        public void UpdateReference(T value)
        {
            this.Value = value;
        }

        public static implicit operator T(SharedReference<T> reference)
        {
            return reference.Value;
        }
    }
}
