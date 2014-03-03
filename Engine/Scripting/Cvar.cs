namespace DarkTech.Engine.Scripting
{
    public abstract class Cvar
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public CvarFlag Flags { get; private set; }

        internal Cvar(string name, string description, CvarFlag flags)
        {
            this.Name = name;
            this.Description = description;
            this.Flags = flags;
        }

        public abstract void Parse(ArgList args);

        public bool HasFlag(CvarFlag flag)
        {
            return (Flags & flag) == flag;
        }

        public void SetFlag(CvarFlag flag)
        {
            Flags |= flag;
        }

        public void ClearFlag(CvarFlag flag)
        {
            Flags &= ~flag;
        }

        public void MarkRead()
        {
            ClearFlag(CvarFlag.Modified);
        }
    }
}
