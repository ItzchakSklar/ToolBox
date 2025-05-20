using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Toolbox
{
    internal class Wrench : Tool
    {
        public Wrench(string name = "Wrench", double weight = 1.2)
        {
            Name = name;
            Weight = weight;
        }
        public override void Describe()
        {
            Console.WriteLine($"A wrench is a tool used to grip and turn bolts, nuts, or other hard-to-turn items.");
        }
        public override void Use()
        {
            Console.WriteLine("Place the jaws around the bolt or nut and turn the handle to tighten or loosen it.");
        }
    }
}
