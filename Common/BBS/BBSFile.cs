using System.IO;

using DarkTech.Common.Utils;

namespace DarkTech.Common.BBS
{
    public sealed class BBSFile
    {
        private delegate void SaveDelegate(Stream stream);
        private delegate void LoadDelegate(Stream stream);

        public BlockNode Root { get; set; }
        public byte Version { get; set; }
        public BBSFlags Flags { get; set; }

        public void Save(Stream stream)
        {
            stream.WriteByte(Version);
            stream.WriteByte((byte)Flags);

            SaveDelegate saveDelegate = GetSaveDelegate(Version);

            saveDelegate(stream);
        }

        public void Load(Stream stream)
        {
            Root = new BlockNode();
            Version = stream.ReadByteEx();
            Flags = (BBSFlags)stream.ReadByteEx();

            LoadDelegate loadDelegate = GetLoadDelegate(Version);

            loadDelegate(stream);
        }

        private void Save_Version0(Stream stream)
        {
            Root.Serialize(stream);
        }

        private void Load_Version0(Stream stream)
        {
            Root.Deserialize(stream);
        }

        private SaveDelegate GetSaveDelegate(byte version)
        {
            switch (version)
            {
                case 0:
                    return new SaveDelegate(Save_Version0);
                default:
                    throw new BBSException("No save delegate for version " + version);
            }
        }

        private LoadDelegate GetLoadDelegate(byte version)
        {
            switch (version)
            {
                case 0:
                    return new LoadDelegate(Load_Version0);
                default:
                    throw new BBSException("No load delegate for version " + version);
            }
        }
    }
}
