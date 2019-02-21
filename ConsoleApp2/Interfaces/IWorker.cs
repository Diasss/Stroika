using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    public enum Position
    {
        worker, manager
    }
    public interface IWorker
    {
        string fullName { get; set; }
        double salary { get; set; }
        Position position { get; }

        void PrintInfo();
        double CalculateSalary(TimeSpan timeSpan);
     
    }
}
