using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Toolbox
{
    internal class Drill:Tool
    {
        public Drill(string name = "Drill", double weight = 3)
        {
            Name = name;
            Weight = weight;
        }
        public override void Describe()
        {
            Console.WriteLine($"A drill is a power tool used to make holes in various materials using a rotating drill bit.");
        }
        public override void Use()
        {
            Console.WriteLine("Insert the appropriate bit, align it with the target surface, and press the trigger while applying steady pressure.");
        }
    }
}
