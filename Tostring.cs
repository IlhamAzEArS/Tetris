using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {

            string[,,] TestExam = new string[7, 4, 1] {

                {
                 {"1ci sual" },
                {"Men1" },
                {"Sen1" },
                {"biz1" }
                },
                {{"2ci sual" },
                {"Men2" },
                {"Sen2" },
                {"biz2" }
                },
                {{"3ci sual" },
                {"Men3" },
                {"Sen3" },
                {"biz3" }
                },
                {{"4ci sual" },
                {"Men4" },
                {"Sen4" },
                {"biz4" }
                },
                {{"5ci sual" },
                {"Men5" },
                {"Sen5" },
                {"biz5" }
                },
                {{"6ci sual" },
                {"Men6" },
                {"Sen6" },
                {"biz6" }
                },
                {{"7ci sual" },
                {"Men7" },
                {"Sen7" },
                {"biz7" }
                },

            };
            Random Next_ = new Random();
            string[,] new_Exam = new string[4, 1];
            int rand_n;
                string[] input = new string[] {"Men1","Men2" ,"Men3", "Men4", "Men5", "Men6","Men7"};

            while (true)
            {
                
               
                int rand = Next_.Next(0, 7);
                
                
                new_Exam[0, 0] = TestExam[rand, 0, 0];
                

                for (int i = 1, j = 0, k = 1; i < 4; i++)
                { 
                    rand_n = Next_.Next(1, 4);
                    while (true)
                    {
                        if (new_Exam[1, j] == TestExam[rand, rand_n, j]){i--;break;}
                        if (new_Exam[2, j] == TestExam[rand, rand_n, j]){i--;break;}
                        else{new_Exam[i, j] = TestExam[rand, rand_n, j];break; }
                    }

                }
                 for (int i = 0; i < 4; i++) { 
                    for (int j = 0; j < 1; j++) { 
                        Console.WriteLine(new_Exam[i, j]);
                    
                    }
                }

                int intTemp = Convert.ToInt32(Console.ReadLine());


                    if (new_Exam[intTemp, 0] == input[intTemp])
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(new_Exam[i, j]);
                                Console.ResetColor();

                            }
                        }
                    }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if(new_Exam[])
                        /*
                        burda qalmnisham 
                        
                        */
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.ResetColor();

                    }
                }
                


            }

        }
    }
}
