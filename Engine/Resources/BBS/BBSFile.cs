using System.IO;

namespace DarkTech.Engine.Resources.BBS
{
    public sealed class BBSFile
    {
        private delegate bool SaveDelegate(Stream stream);
        private delegate bool LoadDelegate(Stream stream);

        public BlockNode Root { get; set; }
        public byte Version { get; set; }
        public BBSFlags Flags { get; set; }

        public bool Save(Stream stream)
        {
            stream.WriteByte(Version);
            stream.WriteByte((byte)Flags);

            SaveDelegate saveDelegate = GetSaveDelegate(Version);

            if (saveDelegate == null)
            {
                Block.ErrorMessage = "Unknown version";

                return false;
            }

            return saveDelegate(stream);

        }

        public bool Load(Stream stream)
        {
            int iVersion = stream.ReadByte();
            int iFlags = stream.ReadByte();

            if (iVersion == -1 || iFlags == -1)
            {
                Block.ErrorMessage = "Unexpected end of stream";

                return false;
            }

            Root = new BlockNode();
            Version = (byte)iVersion;
            Flags = (BBSFlags)iFlags;

            LoadDelegate loadDelegate = GetLoadDelegate(Version);

            if (loadDelegate == null)
            {
                Block.ErrorMessage = "Unknown version";

                return false;
            }

            return loadDelegate(stream);
        }

        private bool Save_Version0(Stream stream)
        {
            return Root.Serialize(stream);
        }

        private bool Load_Version0(Stream stream)
        {
            return Root.Deserialize(stream);
        }

        private SaveDelegate GetSaveDelegate(byte version)
        {
            switch (version)
            {
                case 0:
                    return new SaveDelegate(Save_Version0);
                default:
                    // Unknown version.
                    return null;
            }
        }

        private LoadDelegate GetLoadDelegate(byte version)
        {
            switch (version)
            {
                case 0:
                    return new LoadDelegate(Load_Version0);
                default:
                    // Unknown version.
                    return null;
            }
        }
    }
}
