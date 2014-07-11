namespace DarkTech.Engine.Sound
{
    public abstract class SoundCommand
    {
        public SoundCommandType Type { get; private set; }

        public SoundCommand(SoundCommandType type)
        {
            this.Type = type;
        }
    }
}
