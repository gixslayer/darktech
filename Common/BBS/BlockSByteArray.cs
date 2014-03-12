﻿using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BlockSByteArray : BlockArray<sbyte>
    {
        public BlockSByteArray() : this(0) { }
        public BlockSByteArray(int length) : base(BlockType.SByteArray, length) { }

        protected override void SerializeElement(Stream stream, sbyte element)
        {
            stream.WriteSByte(element);
        }

        protected override sbyte DeserializeElement(Stream stream)
        {
            return stream.ReadSByte();
        }
    }
}