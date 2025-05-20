using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Toolbox
{
    internal class Hammer : Tool
    {
        public Hammer(string name = "Hammer", double weight = 1.5)
        {
            Name = name;
            Weight = weight;
        }
        public override void Describe()
        {
            Console.WriteLine($"A hammer is a hand tool with a metal head used to drive nails or break objects.");
        }
        public override void Use()
        {
            Console.WriteLine("Grip the handle and strike nails or surfaces to drive or break them.");
        }
    }
}
