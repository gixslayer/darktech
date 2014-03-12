﻿using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockUInt : BlockData<uint>
    {
        public BlockUInt() : this(0u) { }
        public BlockUInt(uint defaultValue) : base(BlockType.UInt, defaultValue) { }

        public override void Serialize(Stream stream)
        {
            stream.WriteUInt(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadUInt();
        }
    }
}