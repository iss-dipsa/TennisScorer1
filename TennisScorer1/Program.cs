using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*  SU-TING CHEN */

namespace TennisScorer1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints_1 = 0;
            int totalPoints_2 = 0;
            string score_1 = null;
            string score_2 = null;
            string score = null;
            string dash = null;


            for (totalPoints_1 = 0; totalPoints_1 <= 5; totalPoints_1++)
            {
                for (totalPoints_2 = 0; totalPoints_2 <= 5; totalPoints_2++)
                {
                    //N/A cases
                    if (totalPoints_1 == 5 && totalPoints_2 <= 2)
                    {
                        score_1 = null;
                        score_2 = null;
                        score = "N/A";
                    }
                    if (totalPoints_2 == 5 && totalPoints_1 <= 2)
                    {
                        score_1 = null;
                        score_2 = null;
                        score = "N/A";
                    }

                    //tie and Deuce situations
                    if (totalPoints_1 == totalPoints_2)
                    {
                        if (totalPoints_1 <= 5 && totalPoints_2 <= 5)
                        {

                            if (totalPoints_1 == 0 && totalPoints_2 == 0)
                            {
                                score_1 = null;
                                score_2 = null;
                                score = "Love all";
                            }
                            else if (totalPoints_1 == 1 && totalPoints_2 == 1)
                            {
                                score_1 = null;
                                score_2 = null;
                                score = "15 all";
                            }
                            else if (totalPoints_1 == 2 && totalPoints_2 == 2)
                            {
                                score_1 = null;
                                score_2 = null;
                                score = "30 all";
                            }
                            else if (totalPoints_1 == 3 && totalPoints_2 == 3)
                            {
                                score_1 = null;
                                score_2 = null;
                                score = "Deuce";
                            }
                            else if (totalPoints_1 == 4 && totalPoints_2 == 4)
                            {
                                score_1 = null;
                                score_2 = null;
                                score = "Deuce";
                            }
                            else if (totalPoints_1 == 5 && totalPoints_2 == 5)
                            {
                                score_1 = null;
                                score_2 = null;
                                score = "Deuce";
                            }
                        }
                    }


                    //Game situations
                    if (totalPoints_1 != totalPoints_2 && (totalPoints_1 >= 4 || totalPoints_2 >= 4) && score != "N/A")
                    {
                        if (totalPoints_1 > totalPoints_2)
                        {
                            score_1 = null;
                            score_2 = null;
                            score = "Game A";
                        }
                        else
                        {
                            score_1 = null;
                            score_2 = null;
                            score = "Game B";
                        }
                    }

                    //Advantage situations
                    if ((totalPoints_1 != totalPoints_2) && (totalPoints_1 >= 4 || totalPoints_2 >= 4) && Math.Abs(totalPoints_1 - totalPoints_2) < 2)
                    {
                        if (totalPoints_1 > totalPoints_2)
                        {
                            score_1 = null;
                            score_2 = null;
                            score = "Advantage A";
                        }
                        else
                        {
                            score_1 = null;
                            score_2 = null;
                            score = "Advantage B";
                        }

                    }

                    if (score == null)
                    {
                        if (totalPoints_1 == 1)
                            score_1 = "15";
                        else if (totalPoints_1 == 2)
                            score_1 = "30";
                        else if (totalPoints_1 == 3)
                            score_1 = "40";
                        else if (totalPoints_1 == 0)
                            score_1 = "Love";

                        if (totalPoints_2 == 1)
                            score_2 = "15";
                        else if (totalPoints_2 == 2)
                            score_2 = "30";
                        else if (totalPoints_2 == 3)
                            score_2 = "40";
                        else if (totalPoints_2 == 0)
                            score_2 = "Love";
                    }


                    if (score == null)
                        dash = "-";


                    Console.Write("{0} {1} = {2}{3}{4}{5}\n", totalPoints_1, totalPoints_2, score_1, dash, score_2, score);
                    score = null;
                    dash = null;

                }
            }


        }
    }
}
