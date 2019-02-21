using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    class TeamLeader : IWorker
    {
        public TeamLeader()
        {
            this.position = Position.manager;
        }
        public string fullName { get ; set; }
        public double salary { get; set; }

        public Position position { get; private set; }
        public double CalculateSalary(TimeSpan timeSpan)
        {
            return timeSpan.TotalHours * salary * 1.05;
        }

       

        public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ФИО - {0},\n Должность - {1} ", fullName, position);
            Console.WriteLine("Ставка = {0:0,000 KZT}", salary);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
