using System.Collections.Generic;
using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BlockNode : Block
    {
        private Dictionary<BlockString, Block> blocks;
        
        public BlockNode()
            : base(BlockType.Node)
        {
            this.blocks = new Dictionary<BlockString, Block>();
        }

        public Block this[string name] 
        {
            get
            {
                BlockString blockName = new BlockString(name);

                return blocks.ContainsKey(blockName) ? blocks[blockName] : null;
            }
            set
            {
                BlockString blockName = new BlockString(name);

                if (!blocks.ContainsKey(blockName))
                {
                    blocks.Add(blockName, null);
                }

                blocks[blockName] = value;
            }
        }

        public override bool Serialize(Stream stream)
        {
            foreach (KeyValuePair<BlockString, Block> block in blocks)
            {
                block.Key.Serialize(stream);
                stream.WriteByte((byte)block.Value.Type);
                block.Value.Serialize(stream);
            }

            stream.WriteByte((byte)BlockType.End);

            return true;
        }

        public override bool Deserialize(Stream stream)
        {
            blocks.Clear();

            while (true)
            {
                BlockString name = new BlockString();

                if (!name.Deserialize(stream))
                {
                    return false;
                }

                Block block;

                if (!Block.FromStream(stream, out block))
                {
                    return false;
                }

                if (block is BlockEnd)
                {
                    return true;
                }

                this[name] = block;
            }
        }
    }
}
