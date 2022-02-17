using System;
using System.Collections.Generic;
using System.Linq;


namespace heist
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");

            HeistMembers Team = new HeistMembers();

            Bank bank = new Bank();

            int bankDifficultyLvl = bank.DifficultyLvl + bank.LuckValue();

            while (true)
            {
                
                    Console.WriteLine("Enter your team member's name: ");
                    string name = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(name))
                    {
                        break;
                    }


                    Console.WriteLine("Enter your team member's skill level (positive integer):");
                    string skill = Console.ReadLine();
                    int parsedSkill = int.Parse(skill);


                    Console.WriteLine("Enter your team member's courage factor (decimal between 0.0 and 2.0):");
                    string courage = Console.ReadLine();
                    double parsedCourage = double.Parse(courage);

                    // Console.WriteLine($"{name}, Skill Level: {skill}, Courage Factor: {courage}");


                    Member teamMember = new Member(name, parsedSkill, parsedCourage);



                    //call displayTeam
                    Team.AddMember(new Member(name, parsedSkill, parsedCourage));
                    Team.DisplayMemberInfo();
                    Team.DisplayTotalSkillLevel();
                }

                    Console.WriteLine("Pick the number of trial runs: ");
                    string firstTrialRuns = Console.ReadLine();
                    int trialRuns = int.Parse(firstTrialRuns);

                    void GetTrialRuns()
                    {

                    for (int i = trialRuns; i > 0; i--) 
                    {
                        
                    string input = Console.ReadLine();
                    int parsedInput = int.Parse(input);
                    }
                    }

                    GetTrialRuns();


                if (Team.GetTotalSkillLevel() >= bankDifficultyLvl)
                {
                    Console.WriteLine($"Heist Team Skill Level Total: {Team.GetTotalSkillLevel()}");
                    Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLvl}");
                    Console.WriteLine("SUCCESSFUL HEIST! YOU ARE RICH NOW");
                }
                else
                {
                    Console.WriteLine("Oh gosh, you have failed to rob the bank  :(   dumbass  ");
                }

            }
        }

    }


