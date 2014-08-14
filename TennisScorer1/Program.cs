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
            //Modify this method - use ifs and switches based on the value of a and b
            //Console.WriteLine("____");
            if (a == 0 && b <= 3)
            {
                Console.Write("Love");                
            }
            else if (a == 1 && b <= 3)
            {
                Console.Write("15");
            }
            else if (a == 2 && b <= 3)
            {
                Console.Write("30");
            }
            else if (a == 3 && b <= 2)
            {
                Console.Write("40");
            }
            else if ((a == 4 && b <= 2) || (a == 5 && b == 3))
            {
                Console.Write("Game A");
            }
            else if ((a <= 2 && b == 4) || (a == 3 && b == 5))
            {
                Console.Write("Game B");
            }
            else if ((a <=2 && b == 5) || (a == 5 && b <= 2))
            {
                Console.Write("N/A");
            }            
            else if (a == b && a >= 3)
            {
                Console.Write("Deuce");
            }
            else if (a >= 3 && b >= 3)
            {
                if (a - b == 1) 
                {
                    Console.Write("Advantage A");
                }
                else if (b - a == 1)
                {
                    Console.Write("Advantage B");
                }
            }

            if (a == b && b <= 2)
            {
                Console.Write(" all");
            }
            else if(b == 0 && a <= 3)
            {
                Console.Write("-love");
            }
            else if(a<=3 && b==1)
            {
                Console.Write("-15");
            }
            else if(a<=3 && b==2)
            {
                Console.Write("-30");
            }
            else if(a<=2 && b==3)
            {
                Console.Write("-40");
            }

            Console.WriteLine();
        }
    }
}
