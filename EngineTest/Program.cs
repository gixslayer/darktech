﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DarkTech.Engine.Resources;

namespace EngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourceManager manager = new ResourceManager();

            manager.RegisterResourceLoader<Resource>(new Loader());

            Console.WriteLine(manager.HasResourceLoader<Resource>());

            Console.WriteLine("DONE");
            Console.Read();
        }
    }

    class Resource : IResource
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    class Loader : ResourceLoader<Resource>
    {

        public override bool Load(DarkTech.Engine.Resources.PAK.PakStream stream, out Resource result)
        {
            result = new Resource();

            return true;
        }
    }
}
