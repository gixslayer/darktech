using System;
using System.IO;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public abstract class BlockArray<T> : BlockData<T[]>
    {
        public int Length { get { return Value.Length; } }

        public BlockArray(BlockType blockType) : this(blockType, 0) { }
        public BlockArray(BlockType blockType, int length) : this(blockType, new T[length]) { }
        public BlockArray(BlockType blockType, T[] defaultValue) : base(blockType, defaultValue) { }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                    throw new ArgumentOutOfRangeException("index");

                return Value[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                    throw new ArgumentOutOfRangeException("index");

                Value[index] = value;
            }
        }

        protected abstract void SerializeElement(Stream stream, T element);
        protected abstract T DeserializeElement(Stream stream);

        public override void Serialize(Stream stream)
        {
            stream.WriteUInt((uint)Length);

            for (int i = 0; i < Length; i++)
            {
                SerializeElement(stream, Value[i]);
            }
        }

        public override void Deserialize(Stream stream)
        {
            uint length = stream.ReadUInt();

            Value = new T[length];

            for (int i = 0; i < length; i++)
            {
                Value[i] = DeserializeElement(stream);
            }
        }
    }
}
