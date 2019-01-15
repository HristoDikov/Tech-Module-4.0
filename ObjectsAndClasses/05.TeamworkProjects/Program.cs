using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] splittedInput = Console.ReadLine()
                    .Split("-");

                string creator = splittedInput[0];
                string teamName = splittedInput[1];

                bool isTeamNameExists = teams.Any(x => x.TeamName == teamName);
                bool isCreatorExist = teams.Any(x => x.Creator == creator);

                if (isTeamNameExists == false && isCreatorExist == false)
                {
                    Team team = new Team(creator, teamName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                else if (isTeamNameExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] memberAndTeam = input.Split("->");

                string member = memberAndTeam[0];
                string team = memberAndTeam[1];

                bool isTeamExist = teams.Any(x => x.TeamName == team);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(member) || x.Creator == member);

                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                if (isAlreadyMember)
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    continue;
                }
                if (isTeamExist && isAlreadyMember == false)
                {
                    int indexOfTeam = teams.FindIndex(x=>x.TeamName == team);
                    teams[indexOfTeam].Members.Add(member);
                }
    
            }
            List<Team> teamsWithMembers = teams
                   .Where(x => x.Members.Count > 0)
                   .OrderByDescending(x => x.Members.Count)
                   .ThenBy(x => x.TeamName)
                   .ToList();

            List<Team> teamsWithoutMembers = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (var kvp in teamsWithMembers)
            {
                Console.WriteLine(kvp.TeamName);
                Console.WriteLine($"- {kvp.Creator}");

                foreach (var player in kvp.Members)
                {
                    Console.WriteLine($"-- {player}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var kvp in teamsWithoutMembers)
            {
                Console.WriteLine(kvp.TeamName);
            }
        }
    }
    class Team
    {
        public Team(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"{TeamName}";
            
        }
    }
}
