using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DarkTech.Common.Debug;

namespace EngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            List<object> a = new List<object>();
            List<object> b = new List<object>();
            List<object> c = a;

            Assert.ReferenceEquals(a, c, "fail");

            Assert.GreaterOrEqual(5, 6, "fail");

            Console.WriteLine("DONE");
            Console.Read();
        }
    }
}
