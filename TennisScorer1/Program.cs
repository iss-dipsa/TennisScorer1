using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisScorer1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int scoreA = 0; scoreA <= 5; scoreA++)
            {
                for (int scoreB = 0; scoreB <= 5; scoreB++)
                {
                    Console.Write("{0} {1} = ", scoreA, scoreB);
                    DisplayScore(scoreA, scoreB);
                }
            }
            Console.ReadLine();
        }

        static void DisplayScore(int a, int b)
        {
            string[] s = new string[] {"LOve","15","30","40"} ;

            if ((a == 5 || b == 5) && ((System.Math.Abs(a - b)) >= 3))
            {
                Console.WriteLine("N/A");
            }

            else
            {
                if (a == b)
                {
                    if (a <= 3)
                        Console.WriteLine(s[a] + " All");
                    else
                        Console.WriteLine("Deuce");
                }
                else if ((a >= 4 || b >= 4) && ((System.Math.Abs(a - b)) >= 2))
                {
                    if (a > b)
                        Console.WriteLine("Game A");
                    else
                        Console.WriteLine("Game B");

                }
                else if ((a == 4 || b == 4) && ((System.Math.Abs(a - b)) == 1))
                {
                    if (a > b)
                        Console.WriteLine("Advantage A");
                    else
                        Console.WriteLine("Advantage B");

                }
                else
                {
                    Console.WriteLine("{0}-{1}", s[a], s[b]);
                }

            }
            
        }
    }
}
