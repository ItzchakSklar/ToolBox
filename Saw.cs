using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Toolbox
{
    internal class Saw:Tool
    {
        public Saw(string name = "Saw", double weight = 2)
        {
            Name = name;
            Weight = weight;
        }
        public override void Describe()
        {
            Console.WriteLine($"A saw is a tool with a serrated blade used to cut through materials like wood, plastic, or metal.");
        }
        public override void Use()
        {
            Console.WriteLine("Position the blade on the cutting line and move it back and forth or power it on to slice through the material.");
        }
    }
}
