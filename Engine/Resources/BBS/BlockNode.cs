using System;
using System.Collections.Generic;
using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockNode : BlockData<Dictionary<string, Block>>
    {
        public Dictionary<string, Block>.KeyCollection Keys { get { return Value.Keys; } }
        public Dictionary<string, Block>.ValueCollection Values { get { return Value.Values; } }
        public int Count { get { return Value.Count; } }

        public BlockNode() : base(BlockType.Node, new Dictionary<string,Block>()) { }

        public Block this[string name] 
        {
            get
            {
                if (!Value.ContainsKey(name))
                    throw new KeyNotFoundException();

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
            foreach (KeyValuePair<string, Block> block in Value)
            {
                // FIXME: If a block key is longer than 255 bytes it will be cut off after 255 bytes leading to data loss.

                // Temporary hack solution.
                if (block.Key.Length > 255)
                    throw new BBSException("Node key length cannot exceed 255 bytes");

                BlockString nameBlock = new BlockString(block.Key);

                stream.WriteByte((byte)nameBlock.Type);
                nameBlock.Serialize(stream);
                stream.WriteByte((byte)block.Value.Type);
                block.Value.Serialize(stream);
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

                if (!(block is BlockString))
                    throw new BBSException("Unexpected block type");

                BlockString nameBlock = block as BlockString;

                if (Value.ContainsKey(nameBlock))
                    throw new BBSException("Duplicate entry in BlockNode");

                block = Block.FromStream(stream);

                if (block is BlockEnd)
                    throw new BBSException("BlockEnd not allowed in BlockNode");

                Value.Add(nameBlock, block);
            }
        }
    }
}
