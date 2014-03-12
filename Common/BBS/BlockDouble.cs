﻿using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockDouble : BlockData<double>
    {
        public BlockDouble() : this(0L) { }
        public BlockDouble(double defaultValue) : base(BlockType.Double, defaultValue) { }

        public override void Serialize(Stream stream)
        {
            stream.WriteDouble(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadDouble();
        }
    }
}