using System;

namespace DarkTech.Engine.Graphics.Render.BackEnd
{
    public interface IRenderBackEnd
    {
        bool CreateContext();
        void Start();
    }
}
