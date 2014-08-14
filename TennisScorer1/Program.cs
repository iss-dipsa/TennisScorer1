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
            //define the score calling
            string c = "Love";
            string d = "all";
            string e = "15";
            string f = "30";
            string g = "40";
            string h = "N/A";
            string i = "Game";
            string j = "B";
            string k = "A";
            string l = "Deuce";
            string m = "Advantage";
            //display score calling when A and B have same value
            if (a == b)
                if (a == 0 && b == 0)
                    Console.WriteLine("{0} {1}", c, d);
                else if (a == 2 && b == 2)
                    Console.WriteLine("{0} {1}", f, d);
                else if (a == 1 && b == 1)
                    Console.WriteLine("{0} {1}", e, d);
                else if (a >= 3 && b >= 3)
                    Console.WriteLine("{0}", l);
            //display score calling when A is not equall to B
            if (a != b)
                if (a <= 2 && b == 5)
                    Console.WriteLine("{0}", h);
                else if (a == 5 && b <= 2)
                    Console.WriteLine("{0}", h);
                else if (a <= 2 && b == 4)
                    Console.WriteLine("{0} {1}", i, j);
                else if (a == 3 && b == 5)
                    Console.WriteLine("{0} {1}", i, j);
                else if (a == 4 && b <= 2)
                    Console.WriteLine("{0} {1}", i, k);
                else if (a == 5 && b == 3)
                    Console.WriteLine("{0} {1}", i, k);
                else if ((a == 3 || a == 4) && b == a + 1)
                    Console.WriteLine("{0} {1}", m, j);
                else if (a == b + 1 && (b == 3 || b == 4))
                    Console.WriteLine("{0} {1}", m, k);
            // the rest  
            if (a == 0)
                if (b == 1)
                    Console.WriteLine("{0}-{1}", c, e);
                else if (b == 2)
                    Console.WriteLine("{0}-{1}", c, f);
                else if (b == 3)
                    Console.WriteLine("{0}-{1}", c, g);
            if (a == 1)
                if (b == 0)
                    Console.WriteLine("{0}-{1}", e, c);
                else if (b == 2)
                    Console.WriteLine("{0}-{1}", e, f);
                else if (b == 3)
                    Console.WriteLine("{0}-{1}", e, g);
            if (a == 2)
                if (b == 0)
                    Console.WriteLine("{0}-{1}", f, c);
                else if (b == 1)
                    Console.WriteLine("{0}-{1}", f, e);
                else if (b == 3)
                    Console.WriteLine("{0}-{1}", f, g);
            if (a == 3)
                if (b == 0)
                    Console.WriteLine("{0}-{1}", g, c);
                else if (b == 1)
                    Console.WriteLine("{0}-{1}", g, e);
                else if (b == 2)
                    Console.WriteLine("{0}-{1}", g, f);
        }
    }
}
