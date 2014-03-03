namespace DarkTech.Engine.Scripting
{
    public sealed class CvarString : CvarBase<string>
    {
        internal CvarString(string name, string description, CvarFlag flags, string defaultValue) : base(name, description, flags, defaultValue) { }

        protected override bool TryParse(ArgList args, out string result)
        {
            result = null;

            if (args.Count == 0)
            {
                return false;
            }

            result = args.Next;

            return true;
        }
    }
}
