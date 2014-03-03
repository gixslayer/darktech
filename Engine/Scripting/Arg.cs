namespace DarkTech.Engine.Scripting
{
    public sealed class Arg
    {
        public ArgType Type { get; private set; }
        public string StringValue { get; private set; }
        public int IntValue { get; private set; }
        public float FloatValue { get; private set; }

        public Arg(ArgType type, string value, float fValue, int iValue)
        {
            this.Type = type;
            this.StringValue = value;
            this.IntValue = iValue;
            this.FloatValue = fValue;
        }

        public static implicit operator string(Arg arg)
        {
            return arg.StringValue;
        }

        public static implicit operator float(Arg arg)
        {
            return arg.FloatValue;
        }

        public static implicit operator int(Arg arg)
        {
            return arg.IntValue;
        }

        public static implicit operator bool(Arg arg)
        {
            return arg.IntValue == 1;
        }

        public static implicit operator Arg(string value)
        {
            return new Arg(ArgType.String, value, 0f, 0);
        }

        public static implicit operator Arg(float value)
        {
            return new Arg(ArgType.Numeric, value.ToString(), value, (int)value);
        }

        public static implicit operator Arg(int value)
        {
            return new Arg(ArgType.Numeric, value.ToString(), value, value);
        }

        public static implicit operator Arg(bool value)
        {
            return new Arg(ArgType.Numeric, value ? "1" : "0", value ? 1f : 0f, value ? 1 : 0);
        }
    }
}
