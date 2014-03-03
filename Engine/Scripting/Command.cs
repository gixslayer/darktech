namespace DarkTech.Engine.Scripting
{
    public delegate void CommandHandler(ArgList args);

    public sealed class Command
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool CheatProtected { get; private set; }
        internal CommandHandler Handler { get; private set; }

        internal Command(string name, string description, bool cheatProtected, CommandHandler handler)
        {
            this.Name = name;
            this.Description = description;
            this.CheatProtected = cheatProtected;
            this.Handler = handler;
        }

        public void Execute()
        {
            Execute(ArgList.EMPTY);
        }

        public void Execute(string argString)
        {
            ArgList args = new ArgList();

            args.Parse(argString);

            Execute(args);
        }

        public void Execute(ArgList args)
        {
            Handler.Invoke(args);
        }
    }
}
