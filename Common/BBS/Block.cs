using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

using DarkTech.Common.IO;
using DarkTech.Common.Debug;

namespace DarkTech.Common.BBS
{
    public abstract class Block
    {
        private static readonly Dictionary<BlockType, Type> TYPE_MAPPING = new Dictionary<BlockType, Type>();

        static Block()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (Type type in assembly.GetTypes())
            {
                if (!type.IsClass || type.IsAbstract)
                    continue;
                if (!type.IsSubclassOf(typeof(Block)))
                    continue;
                if (type.ContainsGenericParameters)
                    continue;

                try
                {
                    Block block = (Block)Activator.CreateInstance(type);

                    if (!TYPE_MAPPING.ContainsKey(block.Type))
                    {
                        TYPE_MAPPING.Add(block.Type, block.GetType());
                    }
                    else
                    {
                        Assert.Fail("Duplicate type mapping for Block " + block.Type.ToString());
                    }
                }
                catch (Exception e)
                {
                    Assert.Fail("Failed to create instance for Block type " + type.FullName + " > " + e.Message);
                }
            }
        }

        public BlockType Type { get; private set; }

        public Block(BlockType type)
        {
            this.Type = type;
        }

        public abstract void Serialize(Stream stream);
        public abstract void Deserialize(Stream stream);

        public static Block FromStream(Stream stream)
        {
            BlockType type = ReadBlockType(stream);
            Block block = CreateFromType(type);

            block.Deserialize(stream);

            return block;
        }

        private static BlockType ReadBlockType(Stream stream)
        {
            byte type = stream.ReadByteEx();

            if (!ValidBlockType(type))
                throw new BBSException("Invalid block type");

            return (BlockType)type;
        }

        private static bool ValidBlockType(byte value)
        {
            return Enum.IsDefined(typeof(BlockType), value);
        }

        private static Block CreateFromType(BlockType type)
        {
            if (!TYPE_MAPPING.ContainsKey(type))
                throw new ArgumentException("Could not find type mapping for type", "type");

            return (Block)Activator.CreateInstance(TYPE_MAPPING[type]);
        }
    }
}
