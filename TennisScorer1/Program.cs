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
            string[] score = new string[4] { "Love", "15", "30", "40" };
            if ((a == 5 || b == 5) && (Math.Abs(a - b) >= 3))
            {
                Console.WriteLine("N/A");
            }
            else if ((a >= 4 || b >= 4) && (Math.Abs(a - b) >= 2))
            {
                if (a - b >= 2)
                {
                    Console.WriteLine("GAME A");
                }
                else if (b - a >= 2)
                {
                    Console.WriteLine("GAME B");
                }
            }
            else if (a == b && a >= 3)
            {
                Console.WriteLine("Deuce");
            }
            else if (a >= 4 || b >= 4)
            {
                if (a - b == 1)
                {
                    Console.WriteLine("Advantage A");
                }
                else if (b - a == 1)
                {
                    Console.WriteLine("Advantage B");
                }
            }
            else
            {
                string fin = (score[a].Equals(score[b])) ? score[a] + " all" : score[a] + "-" + score[b];
                Console.WriteLine(fin);
            }
        }
    }
}
