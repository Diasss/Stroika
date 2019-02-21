using ConsoleApp2.Interfaces;
using RandomUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2.Model
{
    public class Team
    {
        public List<IWorker> team = new List<IWorker>();
        private Random rnd = new Random();
        public int countWorker { get; private set; }
        public void createTeam()
        {
            var user = GenerateUser.GetUser();
            TeamLeader teamLeader = new TeamLeader();
            teamLeader.fullName = user.name.title + user.name.first;
            teamLeader.salary = rnd.Next(3000, 10000);
            team.Add(teamLeader);

            for (int i = 0; i < rnd.Next(3,20); i++)
            {
                user = GenerateUser.GetUser();
                Worker worker = new Worker(Position.worker);
                worker.fullName = user.name.title + user.name.first;
                team.Add(worker);
            }
            countWorker = team.Count - 1;
        }

        public IWorker getFreeWorker()
        {
            return team[rnd.Next(0, countWorker)];
        }
    }
}
