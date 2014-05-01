using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DarkTech.Common.BBS
{
    public sealed class BlockNode : BlockData<Dictionary<string, Block>>
    {
        private static readonly Encoding ENCODING = Encoding.UTF8;

        public Dictionary<string, Block>.KeyCollection Keys { get { return Value.Keys; } }
        public Dictionary<string, Block>.ValueCollection Values { get { return Value.Values; } }
        public int Count { get { return Value.Count; } }

        public BlockNode() : this(new Dictionary<string,Block>()) { }
        public BlockNode(Dictionary<string, Block> defaultValue) : base(BlockType.Node, defaultValue) { }

        public Block this[string name] 
        {
            get
            {
                if (!Value.ContainsKey(name))
                    throw new KeyNotFoundException(name);

                return Value[name];
            }
            set
            {
                if (!Value.ContainsKey(name))
                {
                    Value.Add(name, null);
                }

                Value[name] = value;
            }
        }

        public Block Get(string name)
        {
            return this[name];
        }

        public T Get<T>(string name) where T : Block
        {
            if (!Has<T>(name))
                throw new ArgumentException("No block of the given type was found for the specified name", "name");

            return this[name] as T;
        }

        public bool Has(string name)
        {
            return Value.ContainsKey(name);
        }

        public bool Has<T>(string name) where T : Block
        {
            if (!Has(name))
            {
                return false;
            }

            Block block = this[name];

            return typeof(T).IsAssignableFrom(block.GetType());
        }

        public void Clear()
        {
            Value.Clear();
        }

        public void Add(string name, Block value)
        {
            if (Has(name))
                throw new ArgumentException("A block with the given name is already contained in the node", "name");

            Value.Add(name, value);
        }

        public void Put(string name, Block value)
        {
            this[name] = value;
        }

        public void Remove(string name)
        {
            if (Has(name))
            {
                Value.Remove(name);
            }
        }

        public IEnumerator<KeyValuePair<string, Block>> GetEnumerator()
        {
            return Value.GetEnumerator();
        }

        public override void Serialize(Stream stream)
        {
            foreach (KeyValuePair<string, Block> entry in Value)
            {
                // BlockStringEx is being used to allow name lengths past 255 bytes.
                BlockStringEx name = new BlockStringEx(entry.Key, ENCODING);
                Block block = entry.Value;

                stream.WriteByte((byte)name.Type);
                name.Serialize(stream);
                stream.WriteByte((byte)block.Type);
                block.Serialize(stream);
            }

            stream.WriteByte((byte)BlockType.End);
        }

        public override void Deserialize(Stream stream)
        {
            Value.Clear();

            while (true)
            {
                Block block = Block.FromStream(stream);

                if (block is BlockEnd)
                    return;

                if (!(block is BlockStringEx))
                    throw new BBSException(string.Format("Unexpected block type {0}", block.GetType()));

                BlockStringEx name = block as BlockStringEx;

                if (Value.ContainsKey(name))
                    throw new BBSException(string.Format("Duplicate entry {0} in BlockNode", name.Value));

                block = Block.FromStream(stream);

                if (block is BlockEnd)
                    throw new BBSException("Unexpected BlockEnd");

                Value.Add(name, block);
            }
        }

        public override Block Clone()
        {
            return new BlockNode(Value);
        }
    }
}
