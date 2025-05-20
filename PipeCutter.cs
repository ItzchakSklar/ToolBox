using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class PipeCutter : Tool
    {
        public PipeCutter(string name = "Pipe Cutter", double weight = 1)
        {
            Name = name;
            Weight = weight;
        }
        public override void Describe()
        {
            Console.WriteLine("A pipe cutter is a tool designed to make clean, precise cuts through metal or plastic pipes.");
        }
        public override void Use()
        {
            Console.WriteLine("Clamp the cutter around the pipe, tighten the blade against it, and rotate the tool until the pipe is cleanly cut through.");
        }
    }
}
