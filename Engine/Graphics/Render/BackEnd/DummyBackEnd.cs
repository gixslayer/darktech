namespace DarkTech.Engine.Graphics.Render.BackEnd
{
    internal sealed class DummyBackEnd : IRenderBackEnd
    {
        public bool CreateContext() { return true; }
        public void Start() { }
    }
}
