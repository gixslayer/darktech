namespace DarkTech.Common.DDF
{
    internal static class DDFFactory
    {
        public static DDFBase Create(DDFType type)
        {
            switch (type)
            {
                case DDFType.Bool:
                    return new DDFBool();
                case DDFType.Byte:
                    return new DDFByte();
                case DDFType.ByteArray:
                    return new DDFByteArray();
                case DDFType.Char:
                    return new DDFChar();
                case DDFType.Double:
                    return new DDFDouble();
                case DDFType.Float:
                    return new DDFFloat();
                case DDFType.Int:
                    return new DDFInt();
                case DDFType.List:
                    return new DDFList();
                case DDFType.Long:
                    return new DDFLong();
                case DDFType.Map:
                    return new DDFMap();
                case DDFType.SByte:
                    return new DDFSByte();
                case DDFType.Short:
                    return new DDFShort();
                case DDFType.String:
                    return new DDFString();
                case DDFType.UInt:
                    return new DDFUInt();
                case DDFType.ULong:
                    return new DDFULong();
                case DDFType.UShort:
                    return new DDFUShort();

                default:
                    return null;
            }
        }
    }
}
