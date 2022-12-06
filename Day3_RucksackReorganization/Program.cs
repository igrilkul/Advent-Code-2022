using System;
using System.IO;
using System.Linq;

namespace Day3_RucksackReorganization
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = File.ReadAllText(@"C:\Users\Isuskata\source\repos\AdventCalendar22\ConsoleApp1\Day3_RucksackReorganization\input.txt");
            var rucksacks = input.Split("\r\n").ToArray();

            var result = 0;

            for(int i = 0; i < rucksacks.Count() ; i++)
            {
                var rucksackA = rucksacks[i];
                var rucksackB = rucksacks[i+1];
                var rucksackC = rucksacks[i+2];

                var commonItemsA = rucksackA.Intersect(rucksackB);
                var commonItemsB = rucksackB.Intersect(rucksackC);

                var commonItem = commonItemsA.Intersect(commonItemsB).First();

                int itemValue = (int)commonItem;

                if(itemValue >= 97 && itemValue <= 122)
                {
                    itemValue -= 96;
                }
                else
                {
                    itemValue -= 38;
                }

                result += itemValue;
                //Console.WriteLine(rucksack);
                //Console.WriteLine(first);
                //Console.WriteLine(last);
                //Console.WriteLine(commonItem);
                //Console.WriteLine(itemValue);

                i += 2;
            }

            Console.WriteLine(result);
        }
    }
}
