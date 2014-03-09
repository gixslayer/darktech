using System;
using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public abstract class BlockArray<T> : BlockData<T[]>
    {
        public int Length { get { return Value.Length; } }

        public BlockArray(BlockType type) : this(type, 0) { }
        public BlockArray(BlockType type, int length) : base(type, new T[length]) { }

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

        public static implicit operator T[](BlockArray<T> block)
        {
            return block.Value;
        }
    }
}
