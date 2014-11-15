using DarkTech.DarkGL;

namespace DarkTech.Engine.Graphics.Render
{
    internal sealed class OpenGLRenderer : IRenderer
    {
        private Context context;

        public void Initialize()
        {
            ContextSettings settings = ContextSettings.DEFAULT;

            try
            {
                context = Context.CreateContext(Engine.Window.Handle, settings);
            }
            catch (GLException e)
            {
                throw new InitializeException("Failed to create OpenGL context: {0}", e.Message);
            }
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
