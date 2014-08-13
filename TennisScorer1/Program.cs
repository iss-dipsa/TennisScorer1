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
            Console.Write(" ");
            if (a == 0 && b == 0)
                Console.WriteLine("Love all");
            else if (a == 0 && b == 1)
                Console.WriteLine("Love-15");
            else if (a == 0 && b == 2)
                Console.WriteLine("Love-30");
            else if (a == 0 && b == 3)
                Console.WriteLine("Love-40");
            else if (a == 0 && b == 4)
                Console.WriteLine("Game B");
            else if (a == 0 && b == 5)
                Console.WriteLine("N/A");
            else if (a == 1 && b == 0)
                Console.WriteLine("15-love");
            else if (a == 1 && b == 1)
                Console.WriteLine("15 all");
            else if (a == 1 && b == 2)
                Console.WriteLine("15-30");
            else if (a == 1 && b == 3)
                Console.WriteLine("15-40");
            else if (a == 1 && b == 4)
                Console.WriteLine("Game B");
            else if (a == 1 && b == 5)
                Console.WriteLine("N/A");
            else if (a == 2 && b == 0)
                Console.WriteLine("30-love");
            else if (a == 2 && b == 1)
                Console.WriteLine("30-15");
            else if (a == 2 && b == 2)
                Console.WriteLine("30 all");
            else if (a == 2 && b == 3)
                Console.WriteLine("30-40");
            else if (a == 2 && b == 4)
                Console.WriteLine("Game B");
            else if (a == 2 && b == 5)
                Console.WriteLine("N/A");
            else if (a == 3 && b == 0)
                Console.WriteLine("40-love");
            else if (a == 3 && b == 1)
                Console.WriteLine("40-15");
            else if (a == 3 && b == 2)
                Console.WriteLine("40-30");
            else if (a == 3 && b == 3)
                Console.WriteLine("Deuce");
            else if (a == 3 && b == 4)
                Console.WriteLine("Advantage B");
            else if (a == 3 && b == 5)
                Console.WriteLine("Game B");
            else if (a == 4 && b == 0)
                Console.WriteLine("Game A");
            else if (a == 4 && b == 1)
                Console.WriteLine("Game A");
            else if (a == 4 && b == 2)
                Console.WriteLine("Game A");
            else if (a == 4 && b == 3)
                Console.WriteLine("Advantage A");
            else if (a == 4 && b == 4)
                Console.WriteLine("Deuce");
            else if (a == 4 && b == 5)
                Console.WriteLine("Advantage B");
            else if (a == 5 && b == 0)
                Console.WriteLine("N/A");
            else if (a == 5 && b == 1)
                Console.WriteLine("N/A");
            else if (a == 5 && b == 2)
                Console.WriteLine("N/A");
            else if (a == 5 && b == 3)
                Console.WriteLine("Game A");
            else if (a == 5 && b == 4)
                Console.WriteLine("Advantage A");
            else if (a == 5 && b == 5)
                Console.WriteLine("Deuce");

        }
    }
}
