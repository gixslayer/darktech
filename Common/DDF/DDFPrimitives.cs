namespace DarkTech.Common.DDF
{
    public class DDFByte : DDFPrimitiveBase<byte>
    {
        public DDFByte(byte value = 0) 
            : base(DDFType.Byte) 
        {
            this.Value = value;
        }
    }

    public class DDFSByte : DDFPrimitiveBase<sbyte>
    {
        public DDFSByte(sbyte value = 0)
            : base(DDFType.SByte)
        {
            this.Value = value;
        }
    }

    public class DDFBool : DDFPrimitiveBase<bool>
    {
        public DDFBool(bool value = false)
            : base(DDFType.Bool)
        {
            this.Value = value;
        }
    }

    public class DDFChar : DDFPrimitiveBase<char>
    {
        public DDFChar(char value = '\x0')
            : base(DDFType.Char)
        {
            this.Value = value;
        }
    }

    public class DDFShort : DDFPrimitiveBase<short>
    {
        public DDFShort(short value = 0)
            : base(DDFType.Short)
        {
            this.Value = value;
        }
    }

    public class DDFUShort : DDFPrimitiveBase<ushort>
    {
        public DDFUShort(ushort value = 0)
            : base(DDFType.UShort)
        {
            this.Value = value;
        }
    }

    public class DDFInt : DDFPrimitiveBase<int>
    {
        public DDFInt(int value = 0)
            : base(DDFType.Int)
        {
            this.Value = value;
        }
    }

    public class DDFUInt : DDFPrimitiveBase<uint>
    {
        public DDFUInt(uint value = 0)
            : base(DDFType.UInt)
        {
            this.Value = value;
        }
    }

    public class DDFFloat : DDFPrimitiveBase<float>
    {
        public DDFFloat(float value = 0)
            : base(DDFType.Float)
        {
            this.Value = value;
        }
    }

    public class DDFLong : DDFPrimitiveBase<long>
    {
        public DDFLong(long value = 0)
            : base(DDFType.Long)
        {
            this.Value = value;
        }
    }

    public class DDFULong : DDFPrimitiveBase<ulong>
    {
        public DDFULong(ulong value = 0)
            : base(DDFType.ULong)
        {
            this.Value = value;
        }
    }

    public class DDFDouble : DDFPrimitiveBase<double>
    {
        public DDFDouble(double value = 0)
            : base(DDFType.Double)
        {
            this.Value = value;
        }
    }
}
