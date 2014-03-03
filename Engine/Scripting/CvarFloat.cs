namespace DarkTech.Engine.Scripting
{
    public sealed class CvarFloat : CvarBounded<float>
    {
        internal CvarFloat(string name, string description, CvarFlag flags, float defaultValue, float minValue, float maxValue) : base(name, description, flags, defaultValue, minValue, maxValue) { }

        protected override bool TryParse(ArgList args, out float result)
        {
            result = 0f;

            if (args.Count == 0)
            {
                return false;
            }
            if (args.Peek.Type != ArgType.Numeric)
            {
                return false;
            }

            result = args.Next.FloatValue;

            return true;
        }
    }
}
