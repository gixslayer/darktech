using System;
using System.Threading;

using DarkTech.DarkGL;

using DarkTech.Engine.Scripting;
using DarkTech.Engine.Resources;

namespace DarkTech.Engine.Graphics
{
    internal sealed class BackendOpenGL : IRenderBackend
    {
        private Context context;
        private bool sys_smp;

        public bool CreateContext()
        {
            ContextSetting setting = ContextSetting.DEFAULT;
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

        public void Initialize()
        {
            sys_smp = Engine.ScriptingInterface.GetCvarValue<bool>("sys_smp");

            wgl.SwapInterval((int)Engine.ScriptingInterface.GetCvarValue<Vsync>("r_vsync"));
            gl.Viewport(0, 0, Engine.Window.Width, Engine.Window.Height);
            gl.ClearColor(1.0f, 0.7f, 0.4f, 1.0f);

            context.UnmakeCurrent();
        }

        public void Start()
        {
            if (sys_smp)
            {
                Thread renderThread = new Thread(renderLoop);
                renderThread.Name = "Render backend";

                renderThread.Start();
            }
            else
            {
                context.MakeCurrent();
            }
        }

        public void Stop()
        {
            if (sys_smp)
                return;

            Dispose();
        }

        /// <summary>
        /// Processes all queued render commands.
        /// </summary>
        public void Process()
        {
            // If in SMP mode queued render commands are processed on another thread.
            if (sys_smp)
                return;

            ProcessCommands();
        }

        private void Dispose()
        {
            // Dispose all graphics related resource before destroying the context.
            Engine.ResourceManager.DisposeCategory(ResourceCategory.Graphics);

            // Destroy the context.
            context.Dispose();
        }

        private void ProcessCommands()
        {
            foreach (RenderCommand command in Engine.RenderQueue.GetCommands())
            {
                gl.Clear(GL.COLOR_BUFFER_BIT);
            }

            context.SwapBuffers();
        }

        private void renderLoop()
        {
            context.MakeCurrent();

            while (!Engine.ShutdownRequested)
            {
                // Block till render commands are available.
                Engine.RenderQueue.WaitForData();

                ProcessCommands();
            }

            Dispose();
        }
    }
}
