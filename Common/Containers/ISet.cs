namespace DarkTech.Common.Containers
{
    public interface ISet<T> : IContainer<T>
    {
        bool Add(T item);
        bool Contains(T item);
        void Remove(T item);
    }
}
