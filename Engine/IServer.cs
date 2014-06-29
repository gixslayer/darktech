﻿using System;

namespace DarkTech.Engine
{
    public interface IServer : IDisposable
    {
        string Name { get; }
        string Author { get; }
        string Version { get; }

        bool Initialize();

        void Update(float dt);
    }
}