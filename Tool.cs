using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class Tool
    {
        public string Name;
        public double Weight;
        //public Tool(string name, double weight)
        //{
        //    Name = name;
        //    Weight = weight;
        //}

        public virtual void Describe()
        {
            Console.WriteLine($"the name of the tool is {Name} and is wight {Weight}");
        }
        public virtual void Use()
        {
            Console.WriteLine("Tool is being used to bild or fix samthing");
        }
    }
}
