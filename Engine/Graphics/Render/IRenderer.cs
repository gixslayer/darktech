
namespace DarkTech.Engine.Graphics.Render
{
    public interface IRenderer
    {
        bool Initialize();
        void Dispose();

        void BeginFrame();
        void EndFrame();
    }
}
