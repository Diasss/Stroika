using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    class Worker : IWorker
    {
        public Worker(Position position)
        {
            tasks = new List<ITasks>();
            this.position = position;
        }
        public string fullName { get; set; }
        public double salary { get; set; }
        public Position position { get; private set; }
        public List<ITasks> tasks;
        public double CalculateSalary(TimeSpan timeSpan)
        {
            return timeSpan.TotalHours * salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine("ФИО - {0},\n Должность - {1} ", fullName, position);
            Console.WriteLine("Ставка = {0:0,000 KZT}", salary);
        }
    }
}
