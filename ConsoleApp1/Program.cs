using System;
using System.IO;
using System.Linq;

namespace Day1_CalorieCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int highestcalories = 0;

            string input = File.ReadAllText(@"C:\Users\Isuskata\source\repos\AdventCalendar22\ConsoleApp1\ConsoleApp1\input.txt");
            int[] topThree = new int[3];
            var elves = input.Split("\r\n\r\n")
                .Select(p => p.Split("\r\n"))
                .ToArray();

            foreach (var elf in elves)
            {
                int curCalories = 0;
                foreach (var calorie in elf)
                {
                    curCalories += int.Parse(calorie);
                }

                if (curCalories > highestcalories)
                {
                    highestcalories = curCalories;
                }

                

                    int topThreeMinCalories = topThree.Min();

                    if (curCalories > topThreeMinCalories)
                    {
                        int index = Array.IndexOf(topThree, topThreeMinCalories);
                        topThree[index] = curCalories;

                    }
                
                
            }
            int totalTopThree = topThree.Sum();

            Console.WriteLine(highestcalories);
            Console.WriteLine(totalTopThree);
        }
    }
}
