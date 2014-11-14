using System;

using DarkTech.Engine.Scripting;
using DarkTech.Engine.Timing;

namespace DarkTech.Engine
{
    public static partial class Engine
    {
        private static CvarEnum<NetModel> sys_netModel;
        private static DeltaTimer clientTimer;
        private static DeltaTimer serverTimer;
        private static DeltaTimer debugTimer;

        private static void GameLoop()
        {
            ITimer timer = Platform.CreateTimer();

            if (!timer.Initialize())
            {
                Engine.FatalError("Failed to initialize timer for game loop");
            }

            float tsClient = 1.0f / ScriptingInterface.GetCvarValue<int>("cl_fps");
            float tsServer = 1.0f / ScriptingInterface.GetCvarValue<int>("sv_fps");
            float tsDebug = 1.0f;

            sys_netModel = Engine.ScriptingInterface.GetCvar<CvarEnum<NetModel>>("sys_netModel");
            clientTimer = new DeltaTimer(timer, tsClient);
            serverTimer = new DeltaTimer(timer, tsServer);
            debugTimer = new DeltaTimer(timer, tsDebug);
         
            while (!shutdownRequested)
            {
                ServerFrame();
                ClientFrame();
                DebugFrame();
            }

            timer.Dispose();
        }

        private static void ServerFrame()
        {
            if (sys_netModel == NetModel.ClientOnly)
            {
                return;
            }

            serverTimer.Update();

            // Server receive.

            while (serverTimer.HasNextFrame)
            {
                server.Update(serverTimer.Timestep);
                serverTimer.RanFrame();
            }
        }

        private static void ClientFrame()
        {
            if (sys_netModel == NetModel.ServerOnly)
            {
                return;
            }

            clientTimer.Update();

            while (clientTimer.HasNextFrame)
            {
                client.Update(clientTimer.Timestep);
                clientTimer.RanFrame();
            }

            Renderer.BeginFrame();
            client.Render();
            Renderer.EndFrame();
        }

        private static void DebugFrame()
        {
            debugTimer.Update();

            if (debugTimer.HasNextFrame)
            {
                // Compute client/server ups/fps.

                debugTimer.ResetAccumilator();
            }
        }

        private static void sv_fpsCallback(string name, int oldValue, int newValue)
        {
            serverTimer.Timestep = 1.0f / newValue;
        }

        private static void cl_fpsCallback(string name, int oldValue, int newValue)
        {
            clientTimer.Timestep = 1.0f / newValue;
        }
    }
}
