namespace DarkTech.Engine.Scripting
{
    public sealed class CvarInt : CvarBounded<int>
    {
        internal CvarInt(string name, string description, CvarFlag flags, int defaultValue, int minValue, int maxValue) : base(name, description, flags, defaultValue, minValue, maxValue) { }

        protected override bool TryParse(ArgList args, out int result)
        {
            result = 0;

            if (args.Count == 0)
            {
                return false;
            }
            if (args.Peek.Type != ArgType.Numeric)
            {
                return false;
            }

            result = args.Next.IntValue;

            return true;
        }
    }
}
