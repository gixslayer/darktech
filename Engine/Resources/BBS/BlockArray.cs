using System;
using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockArray<T> : BlockData<T[]> where T : Block
    {
        public int Length { get { return Value.Length; } }
        public BlockType SubType { get; private set; }

        public BlockArray() : base(BlockType.Array, new T[0]) 
        {
            // TODO: Set SubType
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Value.Length)
                    throw new ArgumentOutOfRangeException("index");

                return Value[index];
            }
            set
            {
                if (index < 0 || index >= Value.Length)
                    throw new ArgumentOutOfRangeException("index");

                Value[index] = value;
            }
        }

        public override bool Serialize(Stream stream)
        {
            byte[] data = ByteConverter.GetBytes((uint)Length);

            stream.WriteByte((byte)SubType);
            stream.Write(data, 0, data.Length);

            foreach (T block in Value)
            {
                if (!block.Serialize(stream))
                {
                    return false;
                }
            }

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            throw new System.NotImplementedException();
        }
    }
}
