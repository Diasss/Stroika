using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    enum Status
    {
        created, processed, completed
    }
    interface ITasks
    {
        int id { get; set; }
        DateTime begin { get; set; }
        DateTime end { get; set; }
        Status status { get; set; }
        IWorker worker { get; set; }
        IPart part { get; set; }
        void PrintInfo();
    }
}
