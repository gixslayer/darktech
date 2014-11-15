
namespace DarkTech.Engine.Graphics.Render
{
    public interface IRenderer
    {
        void Initialize();
        void Dispose();

        void BeginFrame();
        void EndFrame();
    }
}
