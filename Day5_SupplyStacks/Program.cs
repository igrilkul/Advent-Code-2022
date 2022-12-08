using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day5_SupplyStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Users\Isuskata\source\repos\AdventCalendar22\ConsoleApp1\Day5_SupplyStacks\input.txt");

            string containersPart = input.Split("\r\n\r\n")[0];

            var directionsPart = input.Split("\r\n\r\n")[1];
            var directionsArray = directionsPart.Split("\r\n").Select(p => p.Split(' ')).ToArray();

            var containersCrates = containersPart.Split("\r\n").ToArray();

            char lastContainerChar = containersCrates.Last().Trim().Last();
            int containersCount = (int)Char.GetNumericValue(lastContainerChar);

            List<char>[] containerLanes = new List<char>[containersCount];
            
            InitializeLists(containersCount, containerLanes);

            for (int i = containersCrates.Count() - 2; i >= 0; i--)
            {
                for (int j = 0; j < containersCount; j++)
                {
                    int index = (4 * j) + 1;
                    char curContainer = containersCrates[i][index];
                    if (curContainer != ' ')
                    {
                        containerLanes[j].Add(curContainer);
                    }
                }
            }

            foreach(var direction in directionsArray)
            {
                int ammount = Int32.Parse(direction[1]);
                int sourceIndex = Int32.Parse(direction[3])-1;
                int targetIndex = Int32.Parse(direction[5])-1;

                List<char> containersToMove = containerLanes[sourceIndex].TakeLast(ammount).ToList();
                containerLanes[sourceIndex].RemoveRange(containerLanes[sourceIndex].Count - ammount,ammount);
                
                foreach(var containerToMove in containersToMove)
                {
                    containerLanes[targetIndex].Add(containerToMove);
                }
            }

            foreach(var container in containerLanes)
            {
                Console.Write(container.Last());
            }

        }

        private static void InitializeLists(int containersCount, List<char>[] containerLanes)
        {
            for (int i = 0; i < containersCount; i++)
            {
                containerLanes[i] = new List<char>();
            }
        }
    }
}
