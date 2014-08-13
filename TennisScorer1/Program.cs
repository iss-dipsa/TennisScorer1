using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisScorer1
{
    class Program
    {
        
        public static void Main(string[] args)
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

            //implemenation

            if (a == 0)
            switch (b)
            {
                case 0:
                    Console.WriteLine("Love all");
                    break;
                case 1:
                    Console.WriteLine("Love-15");
                    break;
                case 2:
                    Console.WriteLine("Love-30");
                    break;
                case 3:
                    Console.WriteLine("Love-40");
                    break;
                case 4:
                    Console.WriteLine("Game B");
                    break;
                case 5:
                    Console.WriteLine("N/A");
                    break;                
            }
            else if (a == 1)
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
            else if (a == 2)
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
            else if (a == 3)
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
            else if (a == 4)
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
                        Console.WriteLine("Game A");
                        break;
                    case 4:
                        Console.WriteLine("Deuce");
                        break;
                    case 5:
                        Console.WriteLine("Advantage B");
                        break;
                }
            else if (a == 5)
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

            else
            {
                 Console.WriteLine("____________");
            }
        }
    }
}
