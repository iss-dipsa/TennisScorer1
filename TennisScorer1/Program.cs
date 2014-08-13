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
            switch (a)
            {
                case 0:
                    switch (b)
                    {
                        case 0:
                            Console.WriteLine("love all");
                            break;
                        case 1:
                            Console.WriteLine("love-15");
                            break;
                        case 2:
                            Console.WriteLine("love-30");
                            break;
                        case 3:
                            Console.WriteLine("love-40");
                            break;
                        case 4:
                            Console.WriteLine("Game B");
                            break;
                        case 5:
                            Console.WriteLine("N/A");
                            break;
                    }
                    break;
                case 1:
                    switch (b)
                    {
                        case 0:
                            Console.WriteLine("15-love");
                            break;
                        case 1:
                            Console.WriteLine("15 all");
                            break;
                        case 2:
                            Console.WriteLine("15-30");
                            break;
                        case 3:
                            Console.WriteLine("15-40");
                            break;
                        case 4:
                            Console.WriteLine("Game B");
                            break;
                        case 5:
                            Console.WriteLine("N/A");
                            break;
                }
                    break;
                case 2:
                    switch (b)
                    {
                        case 0:
                            Console.WriteLine("30-love");
                            break;
                        case 1:
                            Console.WriteLine("30-15");
                            break;
                        case 2:
                            Console.WriteLine("30 all");
                            break;
                        case 3:
                            Console.WriteLine("30-40");
                            break;
                        case 4:
                            Console.WriteLine("Game B");
                            break;
                        case 5:
                            Console.WriteLine("N/A");
                            break;
                    }
                    break;
                case 3:
                switch (b)
                    {
                        case 0:
                            Console.WriteLine("40-love");
                            break;
                        case 1:
                            Console.WriteLine("40-15");
                            break;
                        case 2:
                            Console.WriteLine("40-30");
                            break;
                        case 3:
                            Console.WriteLine("Deuce");
                            break;
                        case 4:
                            Console.WriteLine("Advantage B");
                            break;
                        case 5:
                            Console.WriteLine("Game B");
                            break;
                }
                    break;
                case 4:
                    switch (b)
                    {
                        case 0:
                            Console.WriteLine("Game A");
                            break;
                        case 1:
                            Console.WriteLine("Game A");
                            break;
                        case 2:
                            Console.WriteLine("Game A");
                            break;
                        case 3:
                            Console.WriteLine("Advantage A");
                            break;
                        case 4:
                            Console.WriteLine("Deuce");
                            break;
                        case 5:
                            Console.WriteLine("Advantage B");
                            break;
                    }

                    break;
                case 5:
                    switch (b)
                    {
                        case 0:
                            Console.WriteLine("N/A");
                            break;
                        case 1:
                            Console.WriteLine("N/A");
                            break;
                        case 2:
                            Console.WriteLine("N/A");
                            break;
                        case 3:
                            Console.WriteLine("Game A");
                            break;
                        case 4:
                            Console.WriteLine("Advantage A");
                            break;
                        case 5:
                            Console.WriteLine("Deuce");
                            break;
                    }
                    break;
            }
        }
        static void DisplayScore(int b)
        {

        }
    }
}
