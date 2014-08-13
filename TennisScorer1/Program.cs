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
            if ((a == 0) && (b == 0))
            {
                Console.Write(" Love all"); // 0-0
                Console.WriteLine();
            }
            else if ((a == 0) && (b == 1))
            {
                Console.Write(" Love-15"); // 0-1
                Console.WriteLine();
            }
            else if ((a == 0) && (b == 2)) // 0-2
            {
                Console.Write(" Love-30");
                Console.WriteLine();
            }
            else if ((a == 0) && (b == 3)) // 0-3
            {
                Console.Write(" Love-40");
                Console.WriteLine();
            }
            else if ((a == 0) && (b == 4)) // 0-4
            {
                Console.Write(" Game B");
                Console.WriteLine();
            }
            else if ((a == 0) && (b == 5)) // 0-5
            {
                Console.Write(" N/A");
                Console.WriteLine();
            }
            else if ((a == 1) && (b == 0)) // 1-0
            {
                Console.Write(" 15-Love");
                Console.WriteLine();
            }
            else if ((a == 1) && (b == 1)) // 1-1
            {
                Console.Write(" 15 all");
                Console.WriteLine();
            }
            else if ((a == 1) && (b == 2)) // 1-2
            {
                Console.Write(" 15-30");
                Console.WriteLine();
            }
            else if ((a == 1) && (b == 3)) // 1-3
            {
                Console.Write(" 15-40");
                Console.WriteLine();
            }
            else if ((a == 1) && (b == 4)) // 1-4
            {
                Console.Write(" Game B");
                Console.WriteLine();
            }
            else if ((a == 1) && (b == 5)) // 1-5
            {
                Console.Write(" N/A");
                Console.WriteLine();
            }
            else if ((a == 2) && (b == 0)) // 2-0
            {
                Console.Write(" 30-Love");
                Console.WriteLine();
            }
            else if ((a == 2) && (b == 1)) // 2-1
            {
                Console.Write(" 30-15");
                Console.WriteLine();
            }
            else if ((a == 2) && (b == 2)) // 2-2
            {
                Console.Write(" 3 all");
                Console.WriteLine();
            }
            else if ((a == 2) && (b == 3)) // 2-3
            {
                Console.Write(" 30-40");
                Console.WriteLine();
            }
            else if ((a == 2) && (b == 4)) // 2-4
            {
                Console.Write(" Game B");
                Console.WriteLine();
            }
            else if ((a == 2) && (b == 5)) // 2-5
            {
                Console.Write(" N/A");
                Console.WriteLine();
            }
            else if ((a == 3) && (b == 0)) // 3-0
            {
                Console.Write(" 40-Love");
                Console.WriteLine();
            }
            else if ((a == 3) && (b == 1)) // 3-1
            {
                Console.Write(" 40-15");
                Console.WriteLine();
            }
            else if ((a == 3) && (b == 2)) // 3-2
            {
                Console.Write(" 40-30");
                Console.WriteLine();
            }
            else if ((a == 3) && (b == 3)) // 3-3
            {
                Console.Write(" Deuce");
                Console.WriteLine();
            }
            else if ((a == 3) && (b == 4)) // 3-4
            {
                Console.Write(" Advantage B");
                Console.WriteLine();
            }
            else if ((a == 3) && (b == 5)) // 3-5
            {
                Console.Write(" Game B");
                Console.WriteLine();
            }
            else if ((a == 4) && (b == 0)) // 4-0
            {
                Console.Write(" Game A");
                Console.WriteLine();
            }
            else if ((a == 4) && (b == 1)) // 4-1
            {
                Console.Write(" Game A");
                Console.WriteLine();
            }
            else if ((a == 4) && (b == 2)) // 4-2
            {
                Console.Write(" Game A");
                Console.WriteLine();
            }
            else if ((a == 4) && (b == 3)) // 4-3
            {
                Console.Write(" Advantage A");
                Console.WriteLine();
            }
            else if ((a == 4) && (b == 4)) // 4-4
            {
                Console.Write(" Deuce");
                Console.WriteLine();
            }
            else if ((a == 4) && (b == 5)) // 4-5
            {
                Console.Write(" Advantage B");
                Console.WriteLine();
            }
            else if ((a == 5) && (b == 0)) // 5-0
            {
                Console.Write(" N/A");
                Console.WriteLine();
            }
            else if ((a == 5) && (b == 1)) // 5-1
            {
                Console.Write(" N/A");
                Console.WriteLine();
            }
            else if ((a == 5) && (b == 2)) // 5-2
            {
                Console.Write(" N/A");
                Console.WriteLine();
            }
            else if ((a == 5) && (b == 3)) // 5-3
            {
                Console.Write(" Game A");
                Console.WriteLine();
            }
            else if ((a == 5) && (b == 4)) // 5-4
            {
                Console.Write(" Advantage A");
                Console.WriteLine();
            }
            else if ((a == 5) && (b == 5)) // 5-5
            {
                Console.Write(" Deuce");
                Console.WriteLine();

                Console.ReadLine();

                Console.ReadLine();
            }

        }
    }
}
