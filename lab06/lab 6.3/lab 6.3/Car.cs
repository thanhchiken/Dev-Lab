using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6._3
{
    internal class Car
    {
        public string name { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return "Name: " + name + "   Color: " + Color;
        }
    }
}





