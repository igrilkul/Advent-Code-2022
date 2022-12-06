using System;
using System.IO;
using System.Linq;

namespace Day4_CampCleanup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Users\Isuskata\source\repos\AdventCalendar22\ConsoleApp1\Day4_CampCleanup\input.txt");

            var pairs = input.Split("\r\n").Select(p => p.Split(',')).ToArray();

            int counter = 0;
            foreach (var pair in pairs)
            {
                var elfA = pair[0];
                var elfB = pair[1];

                int elfAStart = Int32.Parse(elfA.Split('-')[0]);
                int elfBStart = Int32.Parse(elfB.Split('-')[0]);

                int elfAEnd = Int32.Parse(elfA.Split('-')[1]);
                int elfBEnd = Int32.Parse(elfB.Split('-')[1]);

                bool isContained = false;

                for(int i= elfAStart; i <= elfAEnd; i++)
                {
                    for(int j= elfBStart; j <= elfBEnd; j++)
                    {
                        if(i == j)
                        {
                            counter++;
                            isContained = true;
                            break;
                        }
                    }

                    if (isContained)
                    {
                        break;
                    }
                }
                

            }

            Console.WriteLine(counter);
        }
    }
}
