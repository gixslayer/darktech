using DarkTech.Common.Math;

namespace DarkTech.Engine.Scripting
{
    public sealed class CvarVector2f : CvarBounded<Vector2f>
    {
        internal CvarVector2f(string name, string description, CvarFlag flags, Vector2f defaultValue, Vector2f minValue, Vector2f maxValue)
            : base(name, description, flags, defaultValue, minValue, maxValue) { }

        protected override bool TryParse(ArgList args, out Vector2f result)
        {
            result = Vector2f.ZERO;

            if (args.Count < 2)
            {
                return false;
            }

            Arg[] tokens = new Arg[2];

            for (int i = 0; i < tokens.Length; i++)
            {
                tokens[i] = args.Next;

                if (tokens[i].Type != ArgType.Numeric)
                {
                    return false;
                }
            }

            result.x = tokens[0].FloatValue;
            result.y = tokens[1].FloatValue;

            return true;
        }
    }
}
