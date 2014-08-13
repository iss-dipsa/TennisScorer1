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
                    Console.WriteLine((b == 0) ? "Love all" : (b == 1) ? "Love-15" : (b == 2) ? "Love-30" : (b == 3) ? "Love-40" : (b == 4) ? "Game B" : "N/A");
                    //DisplayScore0(b);
                    break;
                case 1:
                    Console.WriteLine((b == 0) ? "15-love" : (b == 1) ? "15 all" : (b == 2) ? "15-30" : (b == 3) ? "15-40" : (b == 4) ? "Game B" : "N/A");
                    //DisplayScore1(b);
                    break;
                case 2:
                    Console.WriteLine((b == 0) ? "30-love" : (b == 2) ? "30-15" : (b == 2) ? "30 all" : (b == 3) ? "30-40" : (b == 4) ? "Game B" : "N/A");
                    //DisplayScore2(b);
                    break;
                case 3:
                    Console.WriteLine((b == 0) ? "40-love" : (b == 1) ? "40-15" : (b == 2) ? "40-30" : (b == 3) ? "Deuce" : (b == 4) ? "Advantage B" : "Game B");
                    //DisplayScore3(b);
                    break;
                case 4:
                    Console.WriteLine((b == 0) ? "Game A" : (b == 1) ? "Game A" : (b == 2) ? "Game A" : (b == 3) ? "Advantage A" : (b == 4) ? "Deuce" : "Advantage B");
                    //DisplayScore4(b);
                    break;
                case 5:
                    Console.WriteLine((b == 0) ? "N/A" : (b == 1) ? "N/A" : (b == 2) ? "N/A" : (b == 3) ? "Game A" : (b == 4) ? "Advantage A" : "Deuce");
                    //DisplayScore5(b);
                    break;
                default:
                    break;


            }

        }
        //static void DisplayScore0(int b)
        //{
        //    switch(b)
        //    {
        //        case 0:
        //            Console.WriteLine("Love all");
        //            break;
        //        case 1:
        //            Console.WriteLine("Love-15");
        //            break;
        //        case 2:
        //            Console.WriteLine("Love-30");
        //            break;
        //        case 3:
        //            Console.WriteLine("Love-40");
        //            break;

        //        case 4:
        //            Console.WriteLine("Game B");
        //            break;

        //        case 5:
        //            Console.WriteLine("N/A");
        //            break;

        //    }



        //}
        //static void DisplayScore1(int b)
        //{
        //    switch (b)
        //    {
        //        case 0:
        //            Console.WriteLine("15-love");
        //            break;
        //        case 1:
        //            Console.WriteLine("15 all");
        //            break;
        //        case 2:
        //            Console.WriteLine("15-30");
        //            break;
        //        case 3:
        //            Console.WriteLine("15-40");
        //            break;

        //        case 4:
        //            Console.WriteLine("Game B");
        //            break;
        //        case 5:
        //            Console.WriteLine("N/A");
        //            break;

        //    }



        //}
        //static void DisplayScore2(int b)
        //{
        //    switch(b)
        //    {
        //        case 0:
        //            Console.WriteLine("30-love");
        //            break;
        //        case 1:
        //            Console.WriteLine("30-15");
        //            break;
        //        case 2:
        //            Console.WriteLine("30 all");
        //            break;
        //        case 3:
        //            Console.WriteLine("30-40");
        //            break;

        //        case 4:
        //            Console.WriteLine("Game B");
        //            break;

        //        case 5:
        //            Console.WriteLine("N/A");
        //            break;
        //    }


        //}
        //static void DisplayScore3(int b)
        //{
        //    switch (b)
        //    {
        //        case 0:
        //            Console.WriteLine("40-love");
        //            break;
        //        case 1:
        //            Console.WriteLine("40-15");
        //            break;
        //        case 2:
        //            Console.WriteLine("40-30");
        //            break;
        //        case 3:
        //            Console.WriteLine("Deuce");
        //            break;

        //        case 4:
        //            Console.WriteLine("Advantage B");
        //            break;

        //        case 5:
        //            Console.WriteLine("Game B");
        //            break;

        //    }
        //}
        //static void DisplayScore4(int b)
        //{
        //    switch(b)
        //    {
        //        case 0:
        //            Console.WriteLine("Game A");
        //            break;
        //        case 1:
        //            Console.WriteLine("Game A");
        //            break;
        //        case 2:
        //            Console.WriteLine("Game A");
        //            break;
        //        case 3:
        //            Console.WriteLine("Advantage A");
        //            break;

        //        case 4:
        //            Console.WriteLine("Deuce");
        //            break;
        //        case 5:
        //            Console.WriteLine("Advantage B");
        //            break;


        //    }

        //}
        //static void DisplayScore5(int b)
        //{
        //    switch (b)
        //    {
        //        case 0:
        //            Console.WriteLine("N/A");
        //            break;
        //        case 1:
        //            Console.WriteLine("N/A");
        //            break;
        //        case 2:
        //            Console.WriteLine("N/A");
        //            break;
        //        case 3:
        //            Console.WriteLine("Game A");
        //            break;

        //        case 4:
        //            Console.WriteLine("Advantage A");
        //            break;
        //        case 5:
        //            Console.WriteLine("Deuce");
        //            break;


        //    }

        //}
    }
}
