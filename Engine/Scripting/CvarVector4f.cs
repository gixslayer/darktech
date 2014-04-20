using DarkTech.Common.Math;

namespace DarkTech.Engine.Scripting
{
    public sealed class CvarVector4f : CvarBounded<Vector4f>
    {
        internal CvarVector4f(string name, string description, CvarFlag flags, Vector4f defaultValue, Vector4f minValue, Vector4f maxValue)
            : base(name, description, flags, defaultValue, minValue, maxValue) { }

        protected override bool TryParse(ArgList args, out Vector4f result)
        {
            result = Vector4f.ZERO;

            if (args.Count < 4)
            {
                return false;
            }

            Arg[] tokens = new Arg[4];

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
            result.z = tokens[2].FloatValue;
            result.w = tokens[3].FloatValue;

            return true;
        }
    }
}
