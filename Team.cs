using System;
using System.Collections.Generic;
using System.Linq;


namespace heist
{



    public class HeistMembers
    {
        List<Member> Team = new List<Member>();
        public void AddMember(Member teamMember)
        {
            Team.Add(teamMember);


        }
      

        public void DisplayMemberInfo()
        {
            Console.WriteLine("-------Team List-------");
             Console.WriteLine($"Number of team members: {Team.Count}.");
            Console.WriteLine("----------------------------");
            foreach (Member teamMember in Team)
            {

                Console.WriteLine($"{teamMember.name}: Skill: {teamMember.skill}, Courage: {teamMember.courage} ");
            }
        }


        public int GetTotalSkillLevel()
        {
            return Team.Sum(tm => tm.GetSkillLevel());
            
        }

        public void DisplayTotalSkillLevel()
        {
            Console.WriteLine($"Team Skill Level: {GetTotalSkillLevel()}");
        }
    }

}