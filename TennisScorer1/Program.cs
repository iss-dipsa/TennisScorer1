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

            string[] value = new string[4] { "love", "15", "30", "40" };
            if ((a == b))
            {
                if (a >= 3)
                {
                    Console.WriteLine("Deuce \n");
                }
                if (a == 2)
                {
                    Console.WriteLine("30 all \n");

                }
                if (a == 1)
                {
                    Console.WriteLine("15 all \n");
                }
                if (a == 0)
                {
                    Console.WriteLine("Love all \n");
                }
            }

            if ((a >= 3) || (b >= 3))
            {

                //    Console.WriteLine("Game A \n");
                //else if ((b - a) > 2 && (b > a) && ((a==4) || (b==4)))
                //    Console.WriteLine("Game B \n");

                if (((a == 5) || (b == 5)) && ((Math.Abs(a - b)) >= 3))
                    Console.WriteLine("N/A \n");


                else if ((a == 4) || (b == 4))
                {
                    if ((a - b) == 1)
                    {
                        Console.WriteLine("Advantage A \n");
                    }
                    else if ((b - a) == 1)
                    {
                        Console.WriteLine("Advantage B \n");
                    }

                    else if (((a >= 4) || (b >= 4)) && Math.Abs(a - b) >= 2)
                    {
                        if (a - b >= 2)
                            Console.WriteLine("Game A");
                        else if (b - a >= 2)
                            Console.WriteLine("Game B");

                    }

                }

                else if (((a >= 4) || (b >= 4)) && Math.Abs(a - b) >= 2)
                {
                    if (a - b >= 2)
                        Console.WriteLine("Game A");
                    else if (b - a >= 2)
                        Console.WriteLine("Game B");

                }






            }


            if ((a <= 3 && b <= 3) && (a != b))
            {




                Console.WriteLine(value[a] + "-" + value[b]);

            }











            // Console.WriteLine("____");
        }
    }
}
