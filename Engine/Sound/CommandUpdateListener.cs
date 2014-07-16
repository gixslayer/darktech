namespace DarkTech.Engine.Sound
{
    internal sealed class CommandUpdateListener : Command
    {
        public Listener Listener { get; set; }

        internal CommandUpdateListener() : base(CommandType.UpdateListener) { }
    }
}
