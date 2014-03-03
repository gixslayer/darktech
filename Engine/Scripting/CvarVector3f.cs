using DarkTech.Engine.Math;

namespace DarkTech.Engine.Scripting
{
    public sealed class CvarVector3f : CvarBounded<Vector3f>
    {
        internal CvarVector3f(string name, string description, CvarFlag flags, Vector3f defaultValue, Vector3f minValue, Vector3f maxValue)
            : base(name, description, flags, defaultValue, minValue, maxValue) { }

        protected override bool TryParse(ArgList args, out Vector3f result)
        {
            result = Vector3f.ZERO;

            if (args.Count < 3)
            {
                return false;
            }

            Arg[] tokens = new Arg[3];

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

            return true;
        }
    }
}
