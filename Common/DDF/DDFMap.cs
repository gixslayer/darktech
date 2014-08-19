using DarkTech.Common.Containers;
using DarkTech.Common.IO;

namespace DarkTech.Common.DDF
{
    public sealed class DDFMap : DDFBase
    {
        private readonly IMap<string, DDFBase> entries;

        public IMap<string, DDFBase> Entries
        {
            get { return entries; }
        }
        public int Count
        {
            get { return entries.Count; }
        }

        public DDFMap()
            : base(DDFType.Map)
        {
            this.entries = new HashMap<string, DDFBase>();
        }

        public DDFBase this[string name]
        {
            get
            {
                return entries[name];
            }
            set
            {
                // Will overwrite an existing entry.
                entries[name] = value;
            }
        }

        public bool Has(string name)
        {
            return entries.Contains(name);
        }

        public bool Has<T>(string name) where T : DDFBase
        {
            if (!Has(name))
            {
                return false;
            }

            System.Type type = entries[name].GetType();

            return typeof(T).IsAssignableFrom(type);
        }

        public T Get<T>(string name) where T : DDFBase
        {
            return entries[name] as T;
        }

        public void Add(string name, DDFBase value)
        {
            // Must be a unique name.
            entries.Add(name, value);
        }

        public void Remove(string name)
        {
            entries.Remove(name);
        }

        public override void Serialize(DataStream dataStream)
        {
            dataStream.WriteUShort((ushort)entries.Count);

            foreach (KeyValuePair<string, DDFBase> entry in entries)
            {
                new DDFString(entry.Key).Serialize(dataStream);
                dataStream.WriteByte((byte)entry.Value.Type);
                entry.Value.Serialize(dataStream);
            }
        }

        public override void Deserialize(DataStream dataStream)
        {
            entries.Clear();

            ushort count = dataStream.ReadUShort();

            for (int i = 0; i < count; i++)
            {
                DDFString entryName = new DDFString();

                entryName.Deserialize(dataStream);
                DDFType entryType = (DDFType)dataStream.ReadByte();
                DDFBase entry = DDFFactory.Create(entryType);

                entry.Deserialize(dataStream);

                entries.Add(entryName.Value, entry);
            }
        }
    }
}
