using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    class Task : ITasks
    {
        public DateTime begin { get; set; }
        public DateTime end { get; set; }
        public Status status { get; set; }
        public IWorker worker { get; set; }
        public IPart part { get; set; }
        public int id { get; set; }

        public void PrintInfo()
        {
            switch (status)
            {
                case Status.created:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-> ", part.name);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case Status.processed:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-> ", part.name);
                        Console.WriteLine("Начало: {0}", begin);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case Status.completed:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-> ", part.name);
                    Console.WriteLine("Начало: {0}-{1}", begin, end);
                    worker.PrintInfo();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
      
    }
}
