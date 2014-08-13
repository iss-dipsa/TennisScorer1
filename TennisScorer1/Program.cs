

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
            Console.WriteLine("the score system is as follows");
            for (int scoreA = 0; scoreA <= 5; scoreA++)
            {
                for (int scoreB = 0; scoreB <= 5; scoreB++)
                {
                    Console.Write("{0} {1} = ", scoreA, scoreB);
                    Console.WriteLine(DisplayScore(scoreA, scoreB));
                }
            }
            Console.ReadKey();

            Program program = new Program();
            Console.WriteLine("now enter any entry to get the score...");
            program.calculateScore();
            Console.ReadKey();


        }



        static string DisplayScore(int a, int b)
        {
            int[] points = new int[2];
            points[0] = a;
            points[1] = b; 
            string score = null;
            switch (points[0])
            {
                case 0:
                    switch (points[1])
                    {
                        case 0:
                            score = "Love all";
                            break;
                        case 1:
                            score = "Love-15";
                            break;
                        case 2:
                            score = "Love-30";
                            break;
                        case 3:
                            score = "Love-40";
                            break;
                        case 4:
                            score = "Game B";
                            break;
                        default:
                            score = "N/A";
                            break;
                    }
                    break;
                case 1:
                    switch (points[1])
                    {
                        case 0:
                            score = "15-love";
                            break;
                        case 1:
                            score = "15 all";
                            break;
                        case 2:
                            score = "15-30";
                            break;
                        case 3:
                            score = "15-40";
                            break;
                        case 4:
                            score = "Game B"; 
                            break;
                        default:
                            score = "N/A";
                            break;
                    }
                    break;
                case 2:
                    switch (points[1])
                    {
                        case 0:
                            score = "30-love";
                            break;
                        case 1:
                            score = "30-15";
                            break;
                        case 2:
                            score = "30 all";
                            break;
                        case 3:
                            score = "30-40";
                            break;
                        case 4:
                            score = "Game B";
                            break;
                        default:
                            score = "N/A";
                            break;
                    }
                    break;
                case 3:
                    switch (points[1])
                    {
                        case 0:
                            score = "40-love";
                            break;
                        case 1:
                            score = "40-15";
                            break;
                        case 2:
                            score = "40-30";
                            break;
                        case 3:
                            score = "Deuce";
                            break;
                        case 4:
                            score = "Advantage B";
                            break;
                        default:
                            score = "Game B";
                            break;
                    }
                    break;
                case 4:
                    switch (points[1])
                    {
                        case 0:
                            score = "Game A";
                            break;
                        case 1:
                            score = "Game A";
                            break;
                        case 2:
                            score = "Game A";
                            break;
                        case 3:
                            score = "Advantage A";
                            break;
                        case 4:
                            score = "Deuce";
                            break;
                        default:
                            score = "Advantage B";
                            break;
                    }
                    break;
                case 5:
                    switch (points[1])
                    {
                        case 0:
                            score = "N/A";
                            break;
                        case 1:
                            score = "N/A";
                            break;
                        case 2:
                            score = "N/A";
                            break;
                        case 3:
                            score = "Game A";
                            break;
                        case 4:
                            score = "Advantage A";
                            break;
                        default:
                            score = "N/A";
                            break;
                    }
                    break;
            }

            return score;

        }

        //get the points of server and opponent
        public void calculateScore()
        {

            bool continueFlag = true;
            int[] points = new int[2];
            string score = null;

            while (continueFlag)
            {

                try
                {

                    Console.Write("Enter the point of server: ");
                    Int32 server = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the point of opponent: ");
                    Int32 opponent = Convert.ToInt32(Console.ReadLine());

                    points[0] = server;
                    points[1] = opponent;

                    for (int i = 0; i < points.Length; i++)
                    {
                        if (points[i] < 0 || points[i] > 5)
                        {
                            Console.WriteLine("the " + (i + 1) + "th number entered not valid! Program exits");
                            break;
                        }
                    }

                    score = DisplayScore(server, opponent);
                    break;
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("number invalid! If you want to quit, press y!");
                    String flag = Console.ReadLine();
                    //if you enter y or Y, program will exit
                    if ("y".Equals(flag) || "Y".Equals(flag))
                    {
                        continueFlag = false;
                    }
                }
            }

            Console.Write("the score you get is: " + score);

            
        }


            
        
    }
}
