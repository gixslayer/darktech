using System.Collections.Generic;
using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockList : Block
    {
        private List<Block> list;

        public BlockType ListType { get; private set; }
        public List<Block> Value { get { return list; } }
        public int Count { get { return list.Count; } }

        internal BlockList() : this(BlockType.End) { }

        public BlockList(BlockType listType)
            : base(BlockType.List)
        {
            this.list = new List<Block>();
            this.ListType = listType;
        }

        public Block this[int index]
        {
            get 
            { 
                return index >= 0 && index < Count ? list[index] : null; 
            }
            set
            {
                if (index >= 0 && index < Count && MatchType(value, ListType))
                {
                    list[index] = value;
                }
            }
        }

        public bool Add(Block item)
        {
            if (!MatchType(item, ListType))
            {
                return false;
            }

            list.Add(item);

            return true;
        }

        public bool AddRange(Block[] items)
        {
            foreach (Block item in items)
            {
                if (!Add(item))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Remove(Block item)
        {
            return list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            { 
                list.RemoveAt(index);
            }
        }

        public void RemoveRange(int index, int count)
        {
            if (index >= 0 && index + count <= Count)
            {
                list.RemoveRange(index, count);
            }
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Block item)
        {
            return list.Contains(item);
        }

        public T Get<T>(int index) where T : Block
        {
            Block block = this[index];

            if (block == null)
            {
                return null;
            }

            // TODO: Do some type checking before casting.

            return (T)block;
        }

        public override bool Serialize(Stream stream)
        {
            stream.WriteByte((byte)ListType);

            foreach (Block block in list)
            {
                block.Serialize(stream);
            }

            stream.WriteByte((byte)BlockType.End);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            int iListType = stream.ReadByte();

            if (iListType == -1)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            if (!Block.ValidBlockType((byte)iListType))
            {
                Block.ErrorMessage = "Unknown block type";

                return false;
            }

            ListType = (BlockType)iListType;

            if (ListType == BlockType.End)
            {
                Block.ErrorMessage = "Illegal block type in list block";

                return false;
            }

            list.Clear();

            while (true)
            {
                Block block;

                if (!Block.FromStream(stream, out block))
                {
                    return false;
                }

                if (block is BlockEnd)
                {
                    return true;
                }

                list.Add(block);
            }
        }   
    }
}
