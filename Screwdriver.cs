using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Toolbox
{
    internal class Screwdriver:Tool
    {
        public Screwdriver(string name = "Screwdriver", double weight = 0.300)
        {
            Name = name;
            Weight = weight;
        }
        public override void Describe()
        {
            Console.WriteLine($"A screwdriver is a hand tool used to turn screws by matching the tip to the screw head.");
        }
        public override void Use()
        {
            Console.WriteLine("Align the tip with the screw head and rotate the handle to tighten or loosen the screw.");
        }
    }
}
