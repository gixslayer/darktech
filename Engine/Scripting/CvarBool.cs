namespace DarkTech.Engine.Scripting
{
    public sealed class CvarBool : CvarBase<bool>
    {
        internal CvarBool(string name, string description, CvarFlag flags, bool defaultValue) : base(name, description, flags, defaultValue) { }

        protected override bool TryParse(ArgList args, out bool result)
        {
            result = false;

            if (args.Count == 0)
            {
                return false;
            }
            if (args.Peek.Type != ArgType.Numeric)
            {
                return false;
            }

            result = args.Peek.IntValue == 1;

            return true;
        }
    }
}
