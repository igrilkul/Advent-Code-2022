using System;
using System.Collections;
using System.IO;

namespace Day6_TuningTrouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Users\Isuskata\source\repos\AdventCalendar22\ConsoleApp1\Day6_TuningTrouble\input.txt");

            char[] marker = new char[14];

            for(int i = 0 ; i < input.Length; i++)
            {
                var curChar = input[i];
                
                if(i < 14)
                {
                    marker[i] = curChar;
                }
                else
                {
                    CycleMarker(marker, curChar);

                    bool isMarker = true;

                    for (int j = 0; j < marker.Length; j++)
                    {
                        for (int k = 0; k < marker.Length; k++)
                        {
                            if (j == k)
                            {
                                continue;
                            }

                            if (marker[j] == marker[k])
                            {
                                isMarker = false;
                            }
                        }
                    }

                    if (isMarker)
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                }
            }
        }

        private static void CycleMarker(char[] marker, char curChar)
        {
            for (int o = 0; o < marker.Length - 1; o++)
            {
                marker[o] = marker[o + 1];
            }

            marker[marker.Length - 1] = curChar;
        }
    }
}
