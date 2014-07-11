namespace DarkTech.Common.Containers
{
    public interface IQueue<T> : IContainer<T>
    {
        T this[int index] { get; set; }

        void Enqueue(T item);
        T Dequeue();
    }
}
