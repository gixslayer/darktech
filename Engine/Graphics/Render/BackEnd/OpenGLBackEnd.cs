using System;
using System.Threading;

using DarkTech.DarkGL;

using DarkTech.Engine.Scripting;
using DarkTech.Engine.Resources;

using DarkTech.Engine.Timing;

namespace DarkTech.Engine.Graphics.Render.BackEnd
{
    internal sealed class OpenGLBackEnd : IRenderBackEnd
    {
        private readonly RenderQueue renderQueue;
        private Context context;

        public OpenGLBackEnd(RenderQueue renderQueue)
        {
            this.renderQueue = renderQueue;
        }

        public bool CreateContext()
        {
            ContextSettings setting = ContextSettings.DEFAULT;
            //setting.MajorVersion = 3;
            //setting.MinorVersion = 2;
            this.context = Context.CreateContext(Engine.Window.Handle, setting);

            int[] result = new int[1];
            gl.GetIntegerv(GL.MAJOR_VERSION, result);
            Engine.Printf("OpenGL Major = {0}", result[0]);
            gl.GetIntegerv(GL.MINOR_VERSION, result);
            Engine.Printf("OpenGL Minor = {0}", result[0]);

            return true;
        }
        
        public void Start()
        {
            CvarBool r_restartRequested = Engine.ScriptingInterface.GetCvar<CvarBool>("r_restartRequested");

        restart:
            Initialize();

            while (!Engine.ShutdownRequested && !r_restartRequested)
            {
                // Block till render commands are available.
                renderQueue.BeginFrame();

                // Process the window events.
                Engine.Window.ProcessEvents();

                ProcessCommands();

                // Signal the render queue the current command buffer has been depleted.
                renderQueue.EndFrame();
            }

            if (r_restartRequested)
            {
                r_restartRequested.Value = false;

                goto restart;
            }

            Dispose();
        }

        private void Initialize()
        {
            // Adjust window.
            int x = Engine.ScriptingInterface.GetCvarValue<int>("w_x");
            int y = Engine.ScriptingInterface.GetCvarValue<int>("w_y");
            int width = Engine.ScriptingInterface.GetCvarValue<int>("w_width");
            int height = Engine.ScriptingInterface.GetCvarValue<int>("w_height");
            string title = Engine.ScriptingInterface.GetCvarValue<string>("w_title");

            Engine.Window.AdjustWindow(x, y, width, height);
            Engine.Window.SetTitle(title);

            // Set vsync mode.
            wgl.SwapInterval((int)Engine.ScriptingInterface.GetCvarValue<Vsync>("r_vsync"));

            // GL settings.
            gl.Viewport(0, 0, Engine.Window.Width, Engine.Window.Height);
            gl.ClearColor(1.0f, 0.7f, 0.4f, 1.0f);
        }

        private void ProcessCommands()
        {
            // HACK: Should be part of a command?
            gl.Clear(GL.COLOR_BUFFER_BIT);

            RenderCommand command = null;

            while (renderQueue.ConsumerSize != 0)
            {
                command = renderQueue.Consumer.Dequeue();

                command.Execute();
            }

            context.SwapBuffers();
        }

        private void Dispose()
        {
            // Dispose all graphics related resource before destroying the context.
            Engine.ResourceManager.DisposeCategory(ResourceCategory.Graphics);

            // Destroy the context.
            context.Dispose();
        }
    }
}
