using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tool> tools = new List<Tool>();
            tools.Add(new Drill());
            tools.Add(new Drill());
            tools.Add(new Hammer());
            tools.Add(new Saw());

            foreach (Tool tool in tools)
            {
                tool.Describe();
                tool.Use();
            }
        }
    }
}
