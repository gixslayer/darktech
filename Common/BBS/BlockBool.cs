﻿using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockBool : BlockData<bool>
    {
        public BlockBool() : this(false) {}
        public BlockBool(bool defafultValue) : base(BlockType.Bool, defafultValue) {}

        public override void Serialize(Stream stream)
        {
            stream.WriteBool(Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = stream.ReadBool();
        }
    }
}