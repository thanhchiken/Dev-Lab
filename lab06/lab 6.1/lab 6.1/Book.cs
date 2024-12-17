using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6._1
{
    class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return "\n Id: "+ Id + "// Title: " + Title + "// Author: " + Author + 
                "// Publisher: " + Publisher + "// Year: "+ Year + "// Price: " + Price ;
        }
    }
}
