namespace DarkTech.Engine.Sound
{
    internal abstract class Command
    {
        public CommandType Type { get; private set; }

        internal Command(CommandType type)
        {
            this.Type = type;
        }
    }
}
