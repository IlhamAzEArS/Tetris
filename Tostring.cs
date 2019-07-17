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
                 {"Q 1 - Which of the following is correct about variable naming conventions in C#???\n" },
                {" - It should not be a C# keyword.\n" },
                {" - It must not contain any embedded space or symbol such as? - + ! @ # % ^ & * ( ) [ ] { }\n" },
                {" - Both of the above.\n" }
                },
                {
                {"Q 2 - Which of the following defines boxing correctly???\n" },
                {"When a value type is converted to object type, it is called boxing.\n" },
                {"When an object type is converted to a value type, it is called boxing.\n" },
                {"Both of the above.\n" }
                },
                {{"Q 3 - Which of the following converts a type to a 64-bit integer in C#???\n" },
                {"ToSingle\n" },
                {"ToSbyte\n" },
                {"ToInt64\n" }
                },
                {{"Q 4 - Which of the following converts a type to an unsigned big type in C#?\n" },
                {"ToType\n" },
                {"ToUInt16\n" },
                {"ToUInt64\n" }
                },
                {{"Q 5 - Which of the following access specifier in C# allows a class to expose its member variables and member functions to other functions and objects???\n" },
                {"Protected\n" },
                {"Private\n" },
                {"Public\n" }
                },
                {{"Q 6 - Which of the following is true about C# structures?\n" },
                {"Unlike classes, structures cannot inherit other structures or classes." },
                {"Structure members cannot be specified as abstract, virtual, or protected." },
                {"All of the above." }
                },
                {{"Q 7 - Which of the following is the correct about class member variables?\n" },
                {"These private variables can only be accessed using the public member functions.\n" },
                {"Member variables are the attributes of an object (from design perspective) and they are kept private to implement encapsulation.\n" },
                {"Both of the above.\n" }
                },

            };
            Random Next_ = new Random();
            string[,] new_Exam = new string[4, 1];
            int rand_n;
            string[] input = new string[] { " - Both of the above.\n", "A - When a value type is converted to object type, it is called boxing.\n", "ToInt64\n", "ToUInt64\n", "Public\n", "All of the above.\n", "Both of the above.\n" };
            string yess;
            while (true)
            {
                
               
                int rand = Next_.Next(0, 7);
                
                
                new_Exam[0, 0] = TestExam[rand, 0, 0];
                yess = input[rand];

                for (int i = 1, j = 0; i < 4; i++)
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

                while (true)
                {
                    int intTemp = Convert.ToInt32(Console.ReadLine());
                    
                    if (intTemp > 3)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (new_Exam[intTemp, 0] == yess)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                if (new_Exam[i, 0] == yess)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(new_Exam[i, j]);
                                    Console.ResetColor();
                                }
                                if(new_Exam[i,0] == new_Exam[intTemp,0])
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(new_Exam[intTemp,0]);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(new_Exam[i, j]);
                                    Console.ResetColor();
                                }

                            }
                        }
                       
                        break;
                    }

                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                if (new_Exam[i, 0] == yess)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(new_Exam[i, j]);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(new_Exam[i, j]);
                                    Console.ResetColor();
                                }

                            }
                        }
                    break;
                    }

                }
                Console.WriteLine("Enter a Next Q.");
                Console.ReadKey();
                Console.Clear();



            }

        }
    }
}
