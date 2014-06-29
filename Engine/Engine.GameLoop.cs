using System;
using System.Threading;

using DarkTech.Engine.Scripting;
using DarkTech.Engine.Timing;

namespace DarkTech.Engine
{
    public static partial class Engine
    {
        private static float tsClient;
        private static float tsServer;
        private static NetModel netModel;

        private static void GameLoop()
        {
            // Store a reference to the net model cvar and compute the time steps for the client and server.
            netModel = Engine.ScriptingInterface.GetCvarValue<NetModel>("sys_netModel");
            tsClient = 1.0f / ScriptingInterface.GetCvarValue<int>("cl_fps");
            tsServer = 1.0f / ScriptingInterface.GetCvarValue<int>("sv_fps");

            ITimer timer = Platform.CreateTimer();
            float accumClient = 0.0f;
            float accumServer = 0.0f;
            float accumDebug = 0.0f;
            float tsDebug = 1.0f;

            int clientFrame = 0;
            int serverFrame = 0;

            if (!timer.Initialize())
            {
                Engine.FatalError("Failed to initialize timer for game loop");
            }

            while (!shutdownRequested)
            {
                // Compute delta time.
                timer.Split();

                // Update accumulators.
                accumClient += timer.ElapsedTime;
                accumServer += timer.ElapsedTime;
                accumDebug += timer.ElapsedTime;

                // Server update.
                if (netModel != NetModel.ClientOnly)
                {
                    while (accumServer >= tsServer)
                    {
                        ServerFrame(tsServer);
                        serverFrame++;

                        accumServer -= tsServer;
                    }
                }

                // Client update.
                if (netModel != NetModel.ServerOnly)
                {
                    if (accumClient >= tsClient)
                    {
                        ClientFrame(tsClient);
                        clientFrame++;

                        accumClient = 0;
                    }
                }

                // Debug.
                if (accumDebug >= tsDebug)
                {
                    Engine.Printf("Client FPS: {0}", clientFrame);
                    Engine.Printf("Server FPS: {0}", serverFrame);

                    clientFrame = 0;
                    serverFrame = 0;

                    accumDebug = 0.0f;
                }
            }

            // Dispose the timer.
            timer.Dispose();
        }

        private static void ServerFrame(float dt)
        {
            // Process network (or should this be a dedicated thread?)
            // Pump event queue

            server.Update(dt);
        }

        private static void ClientFrame(float dt)
        {
            // Process network (or should this be a dedicated thread?)
            // Pump event queue

            client.Update(dt);

            Renderer.BeginFrame();

            client.Render();

            Renderer.EndFrame();
        }

        private static void sv_fpsCallback(string name, int oldValue, int newValue)
        {
            tsServer = 1.0f / newValue;
        }

        private static void cl_fpsCallback(string name, int oldValue, int newValue)
        {
            tsClient = 1.0f / newValue;
        }

        private static void sys_netModelCallback(string name, NetModel oldValue, NetModel newValue)
        {
            netModel = newValue;
        }
    }
}
