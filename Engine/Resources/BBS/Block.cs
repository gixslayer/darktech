using System;
using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public abstract class Block
    {
        public static string ErrorMessage = string.Empty;

        public BlockType Type { get; private set; }

        public Block(BlockType type)
        {
            this.Type = type;
        }

        public abstract bool Serialize(Stream stream);
        public abstract bool Deserialize(Stream stream);

        public static bool FromStream(Stream stream, out Block block)
        {
            block = null;

            int iType = stream.ReadByte();

            if (iType == -1)
            {
                ErrorMessage = "Unexpected end of stream";

                return false;
            }

            if (!ValidBlockType((byte)iType))
            {
                ErrorMessage = "Unknown block type";

                return false;
            }

            BlockType type = (BlockType)iType;

            if (type == BlockType.Array)
            {
                Type subType = typeof(BlockInt);

                Activator.CreateInstance(typeof(BlockArray<>).MakeGenericType(subType));
            }

            block = CreateFromType(type);

            return block.Deserialize(stream);
        }

        public static bool ValidBlockType(byte value)
        {
            return Enum.IsDefined(typeof(BlockType), value);
        }

        public static Block CreateFromType(BlockType type)
        {
            switch (type)
            {
                //case BlockType.Array:
                //    return new BlockArray();
                case BlockType.Bool:
                    return new BlockBool();
                case BlockType.Byte:
                    return new BlockByte();
                case BlockType.Char:
                    return new BlockChar();
                case BlockType.Double:
                    return new BlockDouble();
                case BlockType.End:
                    return new BlockEnd();
                case BlockType.Float:
                    return new BlockFloat();
                case BlockType.Int:
                    return new BlockInt();
                case BlockType.List:
                    return new BlockList();
                case BlockType.Long:
                    return new BlockLong();
                case BlockType.Node:
                    return new BlockNode();
                case BlockType.SByte:
                    return new BlockSByte();
                case BlockType.Short:
                    return new BlockShort();
                case BlockType.String:
                    return new BlockString();
                case BlockType.StringEx:
                    return new BlockStringEx();
                case BlockType.UInt:
                    return new BlockUInt();
                case BlockType.ULong:
                    return new BlockULong();
                case BlockType.UShort:
                    return new BlockUShort();
                default:
                    // Should never occur.
                    return null;
            }
        }

        public static bool MatchType(object obj, BlockType type)
        {
            switch (type)
            {
                //case BlockType.Array:
                //    return obj is BlockArray;
                case BlockType.Bool:
                    return obj is BlockBool;
                case BlockType.Byte:
                    return obj is BlockByte;
                case BlockType.Char:
                    return obj is BlockChar;
                case BlockType.Double:
                    return obj is BlockDouble;
                case BlockType.End:
                    return obj is BlockEnd;
                case BlockType.Float:
                    return obj is BlockFloat;
                case BlockType.Int:
                    return obj is BlockInt;
                case BlockType.List:
                    return obj is BlockList;
                case BlockType.Long:
                    return obj is BlockLong;
                case BlockType.Node:
                    return obj is BlockNode;
                case BlockType.SByte:
                    return obj is BlockSByte;
                case BlockType.Short:
                    return obj is BlockShort;
                case BlockType.String:
                    return obj is BlockString;
                case BlockType.StringEx:
                    return obj is BlockStringEx;
                case BlockType.UInt:
                    return obj is BlockUInt;
                case BlockType.ULong:
                    return obj is BlockULong;
                case BlockType.UShort:
                    return obj is BlockUShort;
                default:
                    return false;
            }
        }
    }
}
