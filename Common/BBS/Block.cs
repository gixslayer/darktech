using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using DarkTech.Common.IO;

namespace DarkTech.Common.BBS
{
    public abstract class Block
    {
        private static readonly Dictionary<BlockType, Type> TYPE_MAPPING = new Dictionary<BlockType, Type>();

        static Block()
        {
            // TODO: Register block types.
            RegisterBlockType<BlockString>(BlockType.String);
        }

        public BlockType Type { get; private set; }

        public Block(BlockType blockType)
        {
            this.Type = blockType;
        }

        public abstract void Serialize(Stream stream);
        public abstract void Deserialize(Stream stream);
        public abstract Block Clone();

        public static Block FromStream(Stream stream)
        {
            BlockType blockType = ReadBlockType(stream);
            Block block = CreateFromType(blockType);

            block.Deserialize(stream);

            return block;
        }

        private static BlockType ReadBlockType(Stream stream)
        {
            byte blockType = stream.ReadByteEx();

            if (!IsValidBlockType(blockType))
                throw new BBSException("Invalid block type");

            return (BlockType)blockType;
        }

        private static bool IsValidBlockType(byte value)
        {
            return Enum.IsDefined(typeof(BlockType), value);
        }

        private static Block CreateFromType(BlockType blockType)
        {
            if (!TYPE_MAPPING.ContainsKey(blockType))
                throw new ArgumentException("Could not find type mapping for type", "blockType");

            return (Block)Activator.CreateInstance(TYPE_MAPPING[blockType]);
        }

        private static void RegisterBlockType<T>(BlockType blockType) where T : Block, new()
        {
            Type type = typeof(T);

            if (type.IsAbstract)
                throw new ArgumentException("Generic type cannot be abstract");
            if (type.IsInterface)
                throw new ArgumentException("Generic type cannot be an interface");
            if (!type.IsClass)
                throw new ArgumentException("Generic type must be a class");
            if (type.ContainsGenericParameters)
                throw new ArgumentException("Generic type cannot contain generic parameters");
            if (TYPE_MAPPING.ContainsKey(blockType))
                throw new ArgumentException("Block type already registered", "blockType");

            TYPE_MAPPING.Add(blockType, type);
        }
    }
}
