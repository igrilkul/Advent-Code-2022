using System;
using System.IO;
using System.Linq;

namespace Day2_RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Users\Isuskata\source\repos\AdventCalendar22\ConsoleApp1\Day2_RockPaperScissors\input.txt");

            var games = input.Split("\r\n")
                .Select(p => p.Split(' ')).ToArray();

            int score = 0;

            foreach(var game in games)
            {   //Elf
                switch (game[0])
                {
                    //Rock
                    case "A":
                        {
                            //You
                            switch (game[1])
                            {
                                //Scissors
                                //Lose
                                case "X":
                                    {
                                        score += (3 + 0);
                                        break;
                                    }
                                //Rock
                                //Draw
                                case "Y":
                                    {
                                        score += (1 + 3);
                                        break;
                                    }
                                //Paper
                                //Win
                                case "Z":
                                    {
                                        score += (2 + 6);
                                        break;
                                    }
                            }
                            break;
                        }
                    //Paper
                    case "B":
                        {
                            //You
                            switch (game[1])
                            {
                                //Rock
                                //Lose
                                case "X":
                                    {
                                        score += (1 + 0);
                                        break;
                                    }
                                //Paper
                                //Draw
                                case "Y":
                                    {
                                        score += (2 + 3);
                                        break;
                                    }
                                //Scissors
                                //Win
                                case "Z":
                                    {
                                        score += (3 + 6);
                                        break;
                                    }
                            }
                            break;
                        }
                    //Scissors
                    case "C":
                        {
                            //You
                            switch (game[1])
                            {
                                //Paper
                                //Lose
                                case "X":
                                    {
                                        score += (2 + 0);
                                        break;
                                    }
                                //Scissors
                                //Draw
                                case "Y":
                                    {
                                        score += (3 + 3);
                                        break;
                                    }
                                //Rock
                                //Win
                                case "Z":
                                    {
                                        score += (1 + 6);
                                        break;
                                    }
                            }
                            break;
                        }

                }
            }

            Console.WriteLine(score);
        }
    }
}
