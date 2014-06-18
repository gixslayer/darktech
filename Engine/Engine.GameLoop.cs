using System;
using System.Threading;

using DarkTech.Engine.Scripting;
using DarkTech.Engine.Timing;

namespace DarkTech.Engine
{
    public static partial class Engine
    {
        private static float tsRender;
        private static NetModel netModel;

        private static void GameLoop()
        {
            netModel = Engine.ScriptingInterface.GetCvarValue<NetModel>("sys_netModel");
            tsRender = 1.0f / ScriptingInterface.GetCvarValue<int>("sys_maxFps");
            ITimer timer = Platform.CreateTimer();
            float accumSystem = 0.0f;
            float accumServer = 0.0f;
            float accumRender = 0.0f;
            float accumDebug = 0.0f;
            float tsSystem = 1.0f / ScriptingInterface.GetCvarValue<int>("sys_ups");
            float tsServer = 1.0f / ScriptingInterface.GetCvarValue<int>("sv_ups");
            float tsDebug = 1.0f;
            bool shouldRender = ScriptingInterface.GetCvarValue<bool>("sys_initGraphics");

            int fps = 0;
            int ups = 0;
            int serverups = 0;

            if (!timer.Initialize())
                Engine.FatalError("Failed to initialize timer for game loop");

            // Spawn threads/acquire context.
            Engine.RenderBackend.Start();

            while (!shutdownRequested)
            {
                // Compute delta time.
                timer.Split();

                // Update accumulators.
                accumSystem += timer.ElapsedTime;
                accumServer += timer.ElapsedTime;
                accumRender += timer.ElapsedTime;
                accumDebug += timer.ElapsedTime;

                // System/client update.
                if (netModel != NetModel.ServerOnly)
                {
                    while (accumSystem >= tsSystem)
                    {
                        Update(tsSystem);
                        ups++;

                        accumSystem -= tsSystem;
                    }
                }

                // Server update.
                if (netModel != NetModel.ClientOnly)
                {
                    while (accumServer >= tsServer)
                    {
                        server.Update(tsServer);
                        serverups++;

                        if (netModel == NetModel.ServerOnly)
                        {
                            Update(tsServer);
                            ups++;
                        }

                        accumServer -= tsServer;
                    }
                }

                // System/client render.
                if (shouldRender)
                {
                    if (accumRender >= tsRender)
                    {
                        Render();
                        fps++;

                        accumRender = 0.0f;
                    }
                }

                // Debug.
                if (accumDebug >= tsDebug)
                {
                    Engine.Printf("Frontend FPS: {0}", fps);
                    Engine.Printf("Frontend UPS: {0}", ups);
                    Engine.Printf("Server UPS: {0}", serverups);

                    fps = 0;
                    ups = 0;
                    serverups = 0;

                    accumDebug = 0.0f;
                }
            }

            // Dispose related resources/context.
            Engine.RenderBackend.Stop();
            timer.Dispose();
        }

        private static void Update(float dt)
        {
            // System update

            if (netModel != NetModel.ServerOnly)
            {
                client.Update(dt);
            }
        }

        private static void Render()
        {
            // HAX:
            Engine.RenderQueue.AddCommand(new Graphics.RenderCommand());

            // System render

            // Jump into client.
            client.Render();

            // Swap render command queue so the data is presented to the render back-end.
            Engine.RenderQueue.Swap();

            // Process all render commands.
            Engine.RenderBackend.Process();
        }

        private static void sys_maxFpsCallback(string name, int oldValue, int newValue)
        {
            tsRender = 1.0f / newValue;
        }

        private static void sys_netModelCallback(string name, NetModel oldValue, NetModel newValue)
        {
            netModel = newValue;
        }
    }
}
