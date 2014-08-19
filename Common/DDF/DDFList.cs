using DarkTech.Common.Containers;
using DarkTech.Common.IO;

namespace DarkTech.Common.DDF
{
    public sealed class DDFList : DDFBase
    {
        private readonly IList<DDFBase> entries;
        private DDFType listType;

        public IList<DDFBase> Entries
        {
            get { return entries; }
        }
        public int Count
        {
            get { return entries.Count; }
        }
        public DDFType ListType
        {
            get { return listType; }
        }

        // Should only used by the factory to create an instance to deserialize with.
        internal DDFList() : this(DDFType.Bool) { }

        public DDFList(DDFType listType) : base(DDFType.List)
        {
            this.entries = new ArrayList<DDFBase>();
            this.listType = listType;
        }

        #region Wrapped Functions
        public DDFBase this[int index]
        {
            get { return entries[index]; }
            set { entries[index] = value; }
        }

        public void Add(DDFBase entry)
        {
            entries.Add(entry);
        }

        public void Remove(DDFBase entry)
        {
            entries.Remove(entry);
        }

        public void RemoveAt(int index)
        {
            entries.RemoveAt(index);
        }

        public bool Contains(DDFBase entry)
        {
            return entries.Contains(entry);
        }

        public int IndexOf(DDFBase entry)
        {
            return entries.IndexOf(entry);
        }
        #endregion

        public T Get<T>(int index) where T : DDFBase
        {
            return entries[index] as T;
        }

        public override void Serialize(DataStream dataStream)
        {
            dataStream.WriteByte((byte)listType);
            dataStream.WriteUShort((ushort)entries.Count);

            foreach (DDFBase entry in entries)
            {
                entry.Serialize(dataStream);
            }
        }

        public override void Deserialize(DataStream dataStream)
        {
            entries.Clear();

            this.listType = (DDFType)dataStream.ReadByte();

            ushort count = dataStream.ReadUShort();

            for (int i = 0; i < count; i++)
            {
                DDFBase entry = DDFFactory.Create(listType);

                entry.Deserialize(dataStream);

                entries.Add(entry);
            }
        }
    }
}
