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
                    if (a == 0)
                        Console.WriteLine("LOve All");
                    else if (a == 1)
                        Console.WriteLine("15-All");
                    else if (a == 2)
                        Console.WriteLine("30-All");
                    else if (a == 3)
                        Console.WriteLine("Deuce");
                    else if (a == 4)
                        Console.WriteLine("Deuce");
                    else if (a == 5)
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
            /*OR this Following is only Conditional Withour Sting
             * 
             * 
             * else if (a == 0)
                {
                    if(b==1)
                          Console.WriteLine("LOve-15");
                    else if (b == 2)
                        Console.WriteLine("LOve-30");
                    else if (b == 3)
                        Console.WriteLine("LOve-40");
                    else if (b == 4)
                        Console.WriteLine("Game B");
                
                }
                else if (a == 1)
                {
                    if (b == 0)
                        Console.WriteLine("15-Love");
                    else if (b == 2)
                        Console.WriteLine("15-30");
                    else if (b == 3)
                        Console.WriteLine("15-40");
                    else if (b == 4)
                        Console.WriteLine("Game B");

                }
                else if (a == 2)
                {
                    if (b == 0)
                        Console.WriteLine("30-Love");
                    else if (b == 1)
                        Console.WriteLine("30-15");
                    else if (b == 3)
                        Console.WriteLine("30-40");
                    else if (b == 4)
                        Console.WriteLine("Game B");

                }
                else if (a == 3)
                {
                    if (b == 0)
                        Console.WriteLine("40-love");
                    else if (b == 1)
                        Console.WriteLine("40-15");
                    else if (b == 2)
                        Console.WriteLine("40-30");
                    else if (b == 4)
                        Console.WriteLine("Advantage B");
                    else if (b == 5)
                        Console.WriteLine("Game B");

                }
                else if (a == 4)
                {
                    if (b == 0)
                        Console.WriteLine("Game A");
                    else if (b == 1)
                        Console.WriteLine("Game A");
                    else if (b == 2)
                        Console.WriteLine("Game A");
                    else if (b == 3)
                        Console.WriteLine("Advantage A");
                    else if (b == 5)
                        Console.WriteLine("Advantage B");

                }
                else if (a == 5)
                {
                    if (b == 3)
                        Console.WriteLine("Game A");
                    else if (b == 4)
                        Console.WriteLine("Advantage A");
                    
                }
            }*/
        }
    }
}
