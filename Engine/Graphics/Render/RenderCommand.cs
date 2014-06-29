namespace DarkTech.Engine.Graphics.Render
{
    internal abstract class RenderCommand
    {
        public static readonly RenderCommand NOP = new CommandNOP();

        public abstract void Execute();
    }
}
