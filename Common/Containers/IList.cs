namespace DarkTech.Common.Containers
{
    public interface IList<T> : IContainer<T>
    {
        T this[int index] { get; set; }

        void Add(T item);
        void Insert(int index, T item);
        void Remove(T item);
        void RemoveAt(int index);
        int IndexOf(T item);
        bool Contains(T item);
    }
}
