using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    interface IPart
    {
        int countPart { get; set; }
        double price { get; set; }
        string name { get; set; }
        int order { get; set; }
        
    }
}
