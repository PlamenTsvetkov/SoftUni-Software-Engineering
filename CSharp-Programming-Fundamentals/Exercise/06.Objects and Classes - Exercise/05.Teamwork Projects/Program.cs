using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                List<string> currentTeam = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (teams.Any(x=>x.TeamName== currentTeam[1]))
                {
                    Console.WriteLine($"Team {currentTeam[1]} was already created!");
                }
                else if (teams.Any(x => x.Creator == currentTeam[0]))
                {
                    Console.WriteLine($"{currentTeam[0]} cannot create another team!");
                }
                else
                {
                    Team team = new Team(currentTeam[1], currentTeam[0]);
                    Console.WriteLine($"Team {currentTeam[1]} has been created by {currentTeam[0]}!");                    
                    teams.Add(team);
                }
                
            }
            string input = string.Empty;
            while ((input=Console.ReadLine())!= "end of assignment")
            {
                List<string> currentMember = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string member = currentMember[0];
                string teamName = currentMember[1];
                if (!(teams.Any(x=>x.TeamName==teamName)))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teams.Any(x=>x.Member.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");//???
                    continue;
                }
                teams[teams.FindIndex(x => x.TeamName == teamName)].Member.Add(member);
            }

        }
        class Team
        {
            public string TeamName { get; set; }
            public string Creator { get; set; }
            public List<string> Member { get; set; }
            public Team(string teamName, string creator)
            {
                this.TeamName = teamName;
                this.Creator = creator;
            }
            
        }
    }
}
