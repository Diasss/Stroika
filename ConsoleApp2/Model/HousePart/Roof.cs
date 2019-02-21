using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model.HousePart
{
    class Roof : IPart
    {
        public int countPart { get; set; }
        public double price { get; set; }
        public string name { get; set; }
        public int order { get; set; }
    }
}
