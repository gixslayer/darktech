﻿using System.IO;

using DarkTech.Engine.Utils;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockInt : BlockData<int>
    {
        public BlockInt() : this(0) { }
        public BlockInt(int defaultValue) : base(BlockType.Int, defaultValue) { }

        public override bool Serialize(Stream stream)
        {
            byte[] buffer = ByteConverter.GetBytes(Value);

            stream.Write(buffer, 0, buffer.Length);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            byte[] buffer = new byte[4];

            if (stream.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Value = ByteConverter.ToInt(buffer, 0);

            return true;
        }
    }
}
