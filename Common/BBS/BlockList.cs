using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public sealed class BlockList : BlockData<List<Block>>, IList<Block>
    {
        public int Count { get { return Value.Count; } }
        public bool IsReadOnly { get { return false; } }

        public BlockList() : base(BlockType.List, new List<Block>()) { }

        public Block this[int index]
        {
            get 
            {
                if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException("index");

                return Value[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException("index");

                Value[index] = value;
            }
        }

        public T Get<T>(int index) where T : Block
        {
            Block block = this[index];

            if (!typeof(T).IsAssignableFrom(block.GetType()))
                throw new InvalidCastException("Cannot cast block to given generic type");

            return block as T;
        }

        public void Add(Block item)
        {
            Value.Add(item);
        }

        public void AddRange(Block[] items)
        {
            Value.AddRange(items);
        }

        public bool Remove(Block item)
        {
            return Value.Remove(item);
        }

        public void RemoveAt(int index)
        {
            Value.RemoveAt(index);
        }

        public void RemoveRange(int index, int count)
        {
            Value.RemoveRange(index, count);
        }

        public void Clear()
        {
            Value.Clear();
        }

        public bool Contains(Block item)
        {
            return Value.Contains(item);
        }

        public int IndexOf(Block item)
        {
            return Value.IndexOf(item);
        }

        public void Insert(int index, Block item)
        {
            Value.Insert(index, item);
        }

        public void CopyTo(Block[] array, int arrayIndex)
        {
            Value.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Block> GetEnumerator()
        {
            return Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override void Serialize(Stream stream)
        {
            foreach (Block block in Value)
            {
                stream.WriteByte((byte)block.Type);
                block.Serialize(stream);
            }

            stream.WriteByte((byte)BlockType.End);
        }

        public override void Deserialize(Stream stream)
        {
            Clear();

            while (true)
            {
                Block block = Block.FromStream(stream);

                if (block is BlockEnd)
                {
                    return;
                }

                Value.Add(block);
            }
        }

    }
}
