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

            if ((a==b) )
            {
                if (a>=3)
                {
                    Console.WriteLine("Deuce \n");
                }
                if(a==2)
                {
                    Console.WriteLine("30 all \n");

                }
                if(a==1)
                {
                    Console.WriteLine("15 all \n");
                }
                if(a==0)
                {
                    Console.WriteLine("Love all \n");
                }
            }
            if ((a >= 3) || (b >= 3))
            {
                if (((a - b) > 2) && (a > b) &&((a==4) || (b==4)))
                    Console.WriteLine("Game A \n");
                else if ((b - a) > 2 && (b > a) && ((a==4) || (b==4)))
                    Console.WriteLine("Game B \n");

                if (((a == 5) || (b == 5)) && ((Math.Abs(a - b)) >= 3))
                    Console.WriteLine("N/A \n");


                if ((a > 3) || (b > 3))
                {
                    if ((a > b) && ((a - b) == 1))
                    {
                        Console.WriteLine("Advantage A \n");
                    }
                    else if ((b > a) && ((b - a) == 1))
                    {
                        Console.WriteLine("Advantage B \n");
                    }
                }
            }



      

            
          // Console.WriteLine("____");
        }
    }
}
