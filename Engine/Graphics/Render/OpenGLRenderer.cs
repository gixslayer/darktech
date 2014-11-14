using DarkTech.DarkGL;

namespace DarkTech.Engine.Graphics.Render
{
    internal sealed class OpenGLRenderer : IRenderer
    {
        private Context context;

        public bool Initialize()
        {
            ContextSettings settings = ContextSettings.DEFAULT;
            context = Context.CreateContext(Engine.Window.Handle, settings);

            return true;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void BeginFrame()
        {
            
        }

        public void EndFrame()
        {
            context.SwapBuffers();
        }
    }
}
