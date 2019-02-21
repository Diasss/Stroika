using ConsoleApp2.Interfaces;
using ConsoleApp2.Model.HousePart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    class HouseBuilding
    {
        public HouseBuilding()
        {
            createProject();
            team.createTeam();
            createTasks();
        }
        List<IPart> parts = new List<IPart>();
        List<ITasks> tasks = new List<ITasks>();
        private Random rnd = new Random();

        Team team = new Team();
        
        private void createProject()
        {
            Basement basement = new Basement()
            {
                countPart = 1,
                price = rnd.Next(),
                name = "basement",
                order = 0
            };
            Roof roof = new Roof()
            {
                countPart = 1,
                price = rnd.Next(),
                name = "roof",
                order = 1
            };
            Walls walls = new Walls()
            {
                countPart = rnd.Next(4, 12),
                price = rnd.Next(),
                name = "Wall",
                order = 2
            };
            parts.Add(basement);
            parts.Add(roof);
            parts.Add(walls);

        }
        private void createTasks()
        {
            int k = 0;
            foreach (IPart part in parts.OrderBy(o=>o.order))
            {
                for (int i = 0; i < part.countPart; i++)
                {
                    Task task = new Task();
                    task.part = part;
                    task.id = k++;
                    tasks.Add(task);
                }
            }
        }
        public void startBuilding()
        {
            ITasks task = getUnfinishedTasks();
            while (task != null)
            {


             
                    tasks[task.id].status = Status.completed;
                    tasks[task.id].worker = team.getFreeWorker();
                    tasks[task.id].begin = DateTime.Now;
                    tasks[task.id].end = DateTime.Now.AddDays(rnd.Next(2, 20));
                    task = getUnfinishedTasks();
                
            }
            Console.WriteLine("Работа завершена");
        }
        public ITasks getUnfinishedTasks()
        {
            return tasks.OrderBy(o => o.part.order).Where(w => w.status == Status.created)
               .FirstOrDefault();
        }
    }
}
