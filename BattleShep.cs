using System;
using System.Collections.Generic;
using System.Text;

namespace ConsollAPP
{
    static class Battle_sea
    {
        static private Random generator = new Random();
        static private int[,] player = new int[10, 10];
        static private int[,] comp = new int[10, 10];
        static private string[] numbers = new string[11] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        static private string[] upper = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        static private string[] lowwer = new string[10] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        static private int pchit;
        static private int playerhit;
        static private int pcshoot;
        static private int playershoot;
        static private bool kp = false;
        static private string name;

         static void display()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" A B C D E F G H I J             A B C D E F G H I J");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ---------------------          ---------------------");

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (player[x, y] == 0) Console.Write(" ");
                    else if (player[x, y] == 1) Console.Write("*");
                    else if (player[x, y] == 10) Console.Write("#");
                    else Console.Write("X");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t" + (x + 1) + "\t");

                for (int y = 0; y < 10; y++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (comp[x, y] == 0) Console.Write(" ");
                    else if (comp[x, y] == 1) Console.Write("*");
                    else if (comp[x, y] == 10) Console.Write("#");
                    else Console.Write("x");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("|");

                Console.Write("\n");
                Console.WriteLine("----------------------          ---------------------");
            }

            Console.WriteLine("Name: " + name + "\t\t\t\t\t PC");
            Console.WriteLine("Hits: " + playerhit + "\t\t\t\t\t Hits: " + pchit);
            Console.WriteLine("Shoots: " + playershoot + "\t\t\t\t Shoots: " + pcshoot + "\n\n");
        } 
        static void comp_ships()
        {

            int co1, co2;

            //2 submarines


            for (int i = 0; i < 2; i++)
            {

                co1 = rnumber(10);

                co2 = rnumber(10);


                if (comp[co1, co2] == 0)
                {
                    comp[co1, co2] = 1;

                }

                else i--;

            }

            // 3 - 6 ships

            for (int counter = 3; counter < 7; counter++)
            {

                co1 = rnumber(10 - counter);
                co2 = rnumber(10 - counter);
                int direction = rnumber(2);
                bool ready = false;

                if (direction == 0)
                {
                    co2 = rnumber(10);

                    do
                    {
                        if ((counter == 3) && ((comp[co1, co2] == 0) && (comp[co1 + 1, co2] == 0) && (comp[co1 + 2, co2] == 0)) || (counter == 4) && ((comp[co1, co2] == 0) && (comp[co1 + 1, co2] == 0) && (comp[co1 + 2, co2] == 0) && (comp[co1 + 3, co2] == 0))
                            || (counter == 5) && ((comp[co1, co2] == 0) && (comp[co1 + 1, co2] == 0) && (comp[co1 + 2, co2] == 0) && (comp[co1 + 3, co2] == 0) && (comp[co1 + 4, co2] == 0))
                            || (counter == 6) && ((comp[co1, co2] == 0) && (comp[co1 + 1, co2] == 0) && (comp[co1 + 2, co2] == 0) && (comp[co1 + 3, co2] == 0) && (comp[co1 + 4, co2] == 0)
                            && (comp[co1 + 5, co2] == 0)))
                        {

                            for (int i = 0; i < counter; i++)
                            {
                                comp[co1 + i, co2] = 1;
                            }
                            ready = true;
                        }
                        else
                        {
                            co1 = rnumber(10 - counter);
                            co2 = rnumber(10 - counter);
                            ready = false;
                        }
                    }
                    while (ready == false);
                }

                if (direction == 1)
                {
                    co1 = rnumber(10);

                    do
                    {
                        if ((counter == 3) && ((comp[co1, co2] == 0) && (comp[co1, co2 + 1] == 0) && (comp[co1, co2 + 2] == 0)) || (counter == 4) && ((comp[co1, co2] == 0) && (comp[co1, co2 + 1] == 0) && (comp[co1, co2 + 2] == 0) && (comp[co1, co2 + 3] == 0))
                            || (counter == 5) && ((comp[co1, co2] == 0) && (comp[co1, co2 + 1] == 0) && (comp[co1, co2 + 2] == 0) && (comp[co1, co2 + 3] == 0) && (comp[co1, co2 + 4] == 0))
                            || (counter == 6) && ((comp[co1, co2] == 0) && (comp[co1, co2 + 1] == 0) && (comp[co1, co2 + 2] == 0) && (comp[co1, co2 + 3] == 0) && (comp[co1, co2 + 4] == 0) && (comp[co1, co2 + 5] == 0)))
                        {
                            for (int i = 0; i < counter; i++)
                            {
                                comp[co1, co2 + i] = 1;
                            }
                            ready = true;
                        }

                        else
                        {
                            co1 = rnumber(10 - counter);
                            co2 = rnumber(10 - counter);
                            ready = false;
                        }
                    }
                    while (ready == false);
                }
            }
        } //comp_ships
        static int rnumber(int number)
        {
            int z;

            z = (int)(generator.NextDouble() * number);
            return (z);
        }
        static void pc_shoot()
        {
            int xshoot, yshoot;
            bool hit = false;

            do
            {
                xshoot = rnumber(10);
                yshoot = rnumber(10);

                if ((player[xshoot, yshoot] == 0) || (player[xshoot, yshoot] == 1))
                {
                    if (player[xshoot, yshoot] == 0)
                    {
                        player[xshoot, yshoot] = 10;
                    }
                    else
                    {
                        player[xshoot, yshoot] = 11;
                        pchit++;
                    }

                    hit = true;
                }
            } while (hit == false);
            pcshoot++;
            display();
        }
        static void player_shoot()
        {
            int xshoot, yshoot;
            string getx, gety;
            bool hit = false;
            bool planex = false;
            bool planey = false;

            do
            {
                do
                {
                    Console.Write("Enter X Coordinate\n");
                    getx = Console.ReadLine();
                    //getx = keypress(getx);
                    yshoot = hposition(getx);
                    if ((yshoot > -1) && (yshoot < 10))
                    {
                        planex = true;
                    }
                    else Console.Write("\nInvalid Input\n");
                } while (planex == false);
                do
                {
                    Console.Write("Enter Y Coordinate\n");
                    gety = Console.ReadLine();
                    xshoot = Convert.ToInt16(gety);
                    xshoot--;
                    if ((xshoot > -1) && (xshoot < 10))
                    {
                        planey = true;
                    }
                    else Console.Write("\nInvalid Input\n");
                } while (planey == false);


                if ((comp[xshoot, yshoot] == 0) || (comp[xshoot, yshoot] == 1))
                {
                    if (comp[xshoot, yshoot] == 0)
                    {
                        comp[xshoot, yshoot] = 10;
                    }
                    else
                    {
                        comp[xshoot, yshoot] = 11;
                        playerhit++;
                    }

                    hit = true;
                }
                else Console.Write("\nAlready Contains a hit.\n");
            } while (hit == false);
            playershoot++;
            display();
        }
        static int hposition(string hchar)
        {
            int hpos;
            int x = System.Convert.ToInt16(hchar[0]);

            switch (x)
            {
                case 'a':
                case 'A':
                    hpos = 0;
                    break;
                case 66:
                case 98:
                    hpos = 1;
                    break;
                case 67:
                case 99:
                    hpos = 2;
                    break;
                case 68:
                case 100:
                    hpos = 3;
                    break;
                case 69:
                case 101:
                    hpos = 4;
                    break;
                case 70:
                case 102:
                    hpos = 5;
                    break;
                case 71:
                case 103:
                    hpos = 6;
                    break;
                case 72:
                case 104:
                    hpos = 7;
                    break;
                case 73:
                case 105:
                    hpos = 8;
                    break;
                case 74:
                case 106:
                    hpos = 9;
                    break;
                case 75:
                case 107:
                    hpos = 10;
                    break;
                case 76:
                case 108:
                    hpos = 11;
                    break;
                default:
                    hpos = 20;
                    break;
            }
            return hpos;
        }
        static string letpress(string key)
        {
            for (int z = 0; z < 10; z++)
            {
                if (key == lowwer[z])
                {
                    return key;
                    kp = true;
                    break;
                }
                if (key == upper[z])
                {
                    return key;
                    kp = true;
                    break;
                }

            }
            kp = false;

            return "Z";

        }
        static string numpress(string key)
        {
            for (int z = 0; z < 10; z++)
            {
                if (key == numbers[z])
                {
                    return key;
                    kp = true;
                    break;
                }
            }
            kp = false;

            return "200";

        }
        static void player_ships()
        {
            int direction, position1, position2;
            string getd, getx, gety;
            bool flag1 = false, ready = false;

            for (int s = 0; s < 2; s++)
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Enter horizontal position");
                        getx = Console.ReadLine();
                        getx = letpress(getx);
                    } while (kp != false);
                    position2 = hposition(getx);
                    kp = false;
                    do
                    {
                        Console.WriteLine("Enter vertical position");
                        gety = Console.ReadLine();
                        gety = numpress(gety);
                    } while (kp != false);
                    position1 = Convert.ToInt16(gety);
                    position1--;
                    kp = false;

                    if ((position1 > -1) && (position1 < 10) && (position2 > -1) && (position2 < 10) && (player[position1, position2] == 0))
                    {
                        player[position1, position2] = 1;
                        flag1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid inputs please try again");
                        flag1 = false;
                    }
                }
                while (flag1 == false);
                flag1 = false;
                display();
            }
            //================================ fill up boat with 3
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("1. Horizontal :: 0. Vertial");
                        getd = Console.ReadLine();
                        getd = numpress(getd);
                    } while (kp != false);
                    direction = Convert.ToInt16(getd);
                    do
                    {
                        Console.WriteLine("Enter horizontal position");
                        getx = Console.ReadLine();
                        getx = letpress(getx);
                    } while (kp != false);
                    position2 = hposition(getx);
                    kp = false;
                    do
                    {
                        Console.WriteLine("Enter vertical position");
                        gety = Console.ReadLine();
                        gety = numpress(gety);
                    } while (kp != false);
                    position1 = Convert.ToInt16(gety);
                    position1--;
                    kp = false;
                    if (((direction == 1) && (position1 > -1) && (position1 < 10) && (position2 > -1) && (position2 < 10))
                        || ((direction == 0) && (position1 > -1) && (position1 < 10) && (position2 > -1) && (position2 < 10)))
                        flag1 = true;
                    else
                        Console.WriteLine("Invalid inputs please try again");
                } while (flag1 == false);
                if (direction == 0)
                {
                    if ((player[position1, position2] == 0) && (player[position1 + 1, position2] == 0)
                        && (player[position1 + 2, position2] == 0))
                    {
                        for (int fill = 0; fill < 3; fill++)
                        {
                            player[position1 + fill, position2] = 1;
                        }
                        ready = true;
                    }
                    else Console.WriteLine("Position contains a ship");
                }
                if (direction == 1)
                {
                    if ((player[position1, position2] == 0) && (player[position1, position2 + 1] == 0)
                        && (player[position1, position2 + 2] == 0))
                    {
                        for (int fill = 0; fill < 3; fill++)
                        {
                            player[position1, position2 + fill] = 1;
                        }
                        ready = true;
                    }
                    else Console.WriteLine("Position contains a ship");
                }
            }
            while (ready == false);
            display();

            ready = false;



            //================================ fill up boat with 4
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("1. Horizontal :: 0. Vertial");
                        getd = Console.ReadLine();
                        getd = numpress(getd);
                    } while (kp != false);
                    direction = Convert.ToInt16(getd);
                    do
                    {
                        Console.WriteLine("Enter horizontal position");
                        getx = Console.ReadLine();
                        getx = letpress(getx);
                    } while (kp != false);
                    position2 = hposition(getx);
                    kp = false;
                    do
                    {
                        Console.WriteLine("Enter vertical position");
                        gety = Console.ReadLine();
                        gety = numpress(gety);
                    } while (kp != false);
                    position1 = Convert.ToInt16(gety);
                    position1--;
                    kp = false;
                    if (((direction == 1) && (position1 > -1) && (position1 < 12) && (position2 > -1) && (position2 < 9))
                       || ((direction == 0) && (position1 > -1) && (position1 < 9) && (position2 > -1) && (position2 < 12)))
                        flag1 = true;
                    else
                    {
                        Console.WriteLine("Invalid inputs please try again");
                        flag1 = false;
                    }


                } while (flag1 == false);

                if (direction == 0)
                {
                    if ((player[position1, position2] == 0) && (player[(position1 + 1), position2] == 0)
                        && (player[(position1 + 2), position2] == 0) && (player[(position1 + 3), position2] == 0))
                    {
                        for (int fill = 0; fill < 4; fill++)
                        {
                            player[position1 + fill, position2] = 1;
                        }
                        ready = true;
                    }
                    else
                        Console.WriteLine("Position contains a ship");
                }

                if (direction == 1)
                {
                    if ((player[position1, position2] == 0) && (player[position1, position2 + 1] == 0)
                        && (player[position1, position2 + 2] == 0) && (player[position1, position2 + 3] == 0))
                    {
                        for (int fill = 0; fill < 4; fill++)
                        {
                            player[position1, position2 + fill] = 1;
                        }
                        ready = true;
                    }
                    else Console.WriteLine("Position contains a ship");
                }
            }
            while (ready == false);
            display();

            ready = false;


            //===================================== 5 box boat

            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("1. Horizontal :: 0. Vertial");
                        getd = Console.ReadLine();
                        getd = numpress(getd);
                    } while (kp != false);
                    direction = Convert.ToInt16(getd);
                    do
                    {
                        Console.WriteLine("Enter horizontal position");
                        getx = Console.ReadLine();
                        getx = letpress(getx);
                    } while (kp != false);
                    position2 = hposition(getx);
                    kp = false;
                    do
                    {
                        Console.WriteLine("Enter vertical position");
                        gety = Console.ReadLine();
                        gety = numpress(gety);
                    } while (kp != false);
                    position1 = Convert.ToInt16(gety);
                    position1--;
                    kp = false;
                    if (((direction == 1) && (position1 > -1) && (position1 < 12) && (position2 > -1) && (position2 < 8))
                       || ((direction == 0) && (position1 > -1) && (position1 < 8) && (position2 > -1) && (position2 < 12)))
                        flag1 = true;
                    else
                    {
                        Console.WriteLine("Invalid inputs please try again");
                        flag1 = false;
                    }

                } while (flag1 == false);

                if (direction == 0)
                {
                    if ((player[position1, position2] == 0) && (player[(position1 + 1), position2] == 0)
                        && (player[(position1 + 2), position2] == 0) && (player[(position1 + 3), position2] == 0) && (player[(position1 + 4), position2] == 0))
                    {
                        for (int fill = 0; fill < 5; fill++)
                        {
                            player[position1 + fill, position2] = 1;
                        }
                        ready = true;
                    }
                    else
                        Console.WriteLine("Position contains a ship");
                }

                if (direction == 1)
                {
                    if ((player[position1, position2] == 0) && (player[position1, position2 + 1] == 0)
                        && (player[position1, position2 + 2] == 0) && (player[position1, position2 + 3] == 0) && (player[position1, position2 + 4] == 0))
                    {
                        for (int fill = 0; fill < 5; fill++)
                        {
                            player[position1, position2 + fill] = 1;
                        }
                        ready = true;
                    }
                    else Console.WriteLine("Position contains a ship");
                }
            }
            while (ready == false);
            display();

            ready = false;

            //===================================== 6 box boat

            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("1. Horizontal :: 0. Vertial");
                        getd = Console.ReadLine();
                        getd = numpress(getd);
                    } while (kp != false);
                    direction = Convert.ToInt16(getd);
                    do
                    {
                        Console.WriteLine("Enter horizontal position");
                        getx = Console.ReadLine();
                        getx = letpress(getx);
                    } while (kp != false);
                    position2 = hposition(getx);
                    kp = false;
                    do
                    {
                        Console.WriteLine("Enter vertical position");
                        gety = Console.ReadLine();
                        gety = numpress(gety);
                    } while (kp != false);
                    position1 = Convert.ToInt16(gety);
                    position1--;
                    kp = false;
                    if (((direction == 1) && (position1 > -1) && (position1 < 12) && (position2 > -1) && (position2 < 7))
                       || ((direction == 0) && (position1 > -1) && (position1 < 7) && (position2 > -1) && (position2 < 12)))
                        flag1 = true;
                    else
                    {
                        Console.WriteLine("Invalid inputs please try again");
                        flag1 = false;
                    }

                } while (flag1 == false);

                if (direction == 0)
                {
                    if ((player[position1, position2] == 0) && (player[(position1 + 1), position2] == 0)
                        && (player[(position1 + 2), position2] == 0) && (player[(position1 + 3), position2] == 0) && (player[(position1 + 4), position2] == 0) && (player[(position1 + 5), position2] == 0))
                    {
                        for (int fill = 0; fill < 6; fill++)
                        {
                            player[position1 + fill, position2] = 1;
                        }
                        ready = true;
                    }
                    else
                        Console.WriteLine("Position contains a ship");
                }

                if (direction == 1)
                {
                    if ((player[position1, position2] == 0) && (player[position1, position2 + 1] == 0)
                        && (player[position1, position2 + 2] == 0) && (player[position1, position2 + 3] == 0) && (player[position1, position2 + 4] == 0) && (player[position1, position2 + 5] == 0))
                    {
                        for (int fill = 0; fill < 6; fill++)
                        {
                            player[position1, position2 + fill] = 1;
                        }
                        ready = true;
                    }
                    else Console.WriteLine("Position contains a ship");
                }
            }
            while (ready == false);
            display();

            ready = false;

        } // player_ships
        public static void MAIN()
        {
            bool winner = false;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            comp_ships();
            display();
            FirstShipCoord4();
            SecondShipCoord4();
            FirstShipCoord3();
            SecondShipCoord3();
            do
            {
                pc_shoot();
                player_shoot();

                if ((pchit == 20) || (playerhit == 20))
                {
                    winner = true;
                }
            } while (winner == false);

            if (pchit == 20) Console.WriteLine("Computer Wins");
            else Console.WriteLine("Player Wins");
        }
        static void Playerr_ships()
        {

            int co1, co2;

            //2 submarines


            for (int i = 0; i < 2; i++)
            {

                co1 = rnumber(10);

                co2 = rnumber(10);


                if (player[co1, co2] == 0)
                {
                    player[co1, co2] = 1;

                }

                else i--;

            }

            // 3 - 6 ships

            for (int counter = 3; counter < 7; counter++)
            {

                co1 = rnumber(10 - counter);
                co2 = rnumber(10 - counter);
                int direction = rnumber(2);
                bool ready = false;

                if (direction == 0)
                {
                    co2 = rnumber(10);

                    do
                    {
                        if ((counter == 3) && ((player[co1, co2] == 0) && (player[co1 + 1, co2] == 0) && (player[co1 + 2, co2] == 0)) || (counter == 4) && ((player[co1, co2] == 0) && (player[co1 + 1, co2] == 0) && (player[co1 + 2, co2] == 0) && (player[co1 + 3, co2] == 0))
                            || (counter == 5) && ((player[co1, co2] == 0) && (player[co1 + 1, co2] == 0) && (player[co1 + 2, co2] == 0) && (player[co1 + 3, co2] == 0) && (player[co1 + 4, co2] == 0))
                            || (counter == 6) && ((player[co1, co2] == 0) && (player[co1 + 1, co2] == 0) && (player[co1 + 2, co2] == 0) && (player[co1 + 3, co2] == 0) && (player[co1 + 4, co2] == 0)
                            && (player[co1 + 5, co2] == 0)))
                        {

                            for (int i = 0; i < counter; i++)
                            {
                                player[co1 + i, co2] = 1;
                            }
                            ready = true;
                        }
                        else
                        {
                            co1 = rnumber(10 - counter);
                            co2 = rnumber(10 - counter);
                            ready = false;
                        }
                    }
                    while (ready == false);
                }

                if (direction == 1)
                {
                    co1 = rnumber(10);

                    do
                    {
                        if ((counter == 3) && ((player[co1, co2] == 0) && (player[co1, co2 + 1] == 0) && (player[co1, co2 + 2] == 0)) || (counter == 4) && ((player[co1, co2] == 0) && (player[co1, co2 + 1] == 0) && (player[co1, co2 + 2] == 0) && (player[co1, co2 + 3] == 0))
                            || (counter == 5) && ((player[co1, co2] == 0) && (player[co1, co2 + 1] == 0) && (player[co1, co2 + 2] == 0) && (player[co1, co2 + 3] == 0) && (player[co1, co2 + 4] == 0))
                            || (counter == 6) && ((player[co1, co2] == 0) && (player[co1, co2 + 1] == 0) && (player[co1, co2 + 2] == 0) && (player[co1, co2 + 3] == 0) && (player[co1, co2 + 4] == 0) && (player[co1, co2 + 5] == 0)))
                        {
                            for (int i = 0; i < counter; i++)
                            {
                                player[co1, co2 + i] = 1;
                            }
                            ready = true;
                        }

                        else
                        {
                            co1 = rnumber(10 - counter);
                            co2 = rnumber(10 - counter);
                            ready = false;
                        }
                    }
                    while (ready == false);
                }
            }
        } //player_ships is random 
        public static void FirstShipCoord4()
        {
            Console.SetCursorPosition(0, 19);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Set Your 4* SHIP and Press [Enter]");
            Random random = new Random();
            int r;
            do
            {
                r = random.Next(36, 50);
            } while (r == player[0,0]);
            for (int i = 0; i < 4; i++)
            {
                player[0, i] = r;
                player[0, i] = i + 3;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(player[0, i], player[0, i]);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("*");
            }
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (player[0, 0] > 36)
                        {

                            if (player[0, 0] - 1 != player[0,0])
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    Console.SetCursorPosition(player[0, k], player[0, k]);
                                    Console.WriteLine(" ");
                                    player[0, k]--;
                                }
                            }
                            else if (player[0, 0] - 1 == player[0,0] && player[0, 0] - 2 >= 36)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    Console.SetCursorPosition(player[0, k], player[0, k]);
                                    Console.WriteLine(" ");
                                    player[0, k] -= 2;
                                }
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            Console.SetCursorPosition(player[0, k], player[0, k]);
                            Console.WriteLine("*");
                        }


                        break;
                    case ConsoleKey.UpArrow:

                        if (player[0, 0] > 3)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Console.SetCursorPosition(player[0, j], player[0, j]);
                                Console.WriteLine(" ");
                                player[0, j]--;
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            Console.SetCursorPosition(player[0, k], player[0, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (player[0, 0] < 49)
                        {
                            if (player[0, 0] + 1 != player[0,0])
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    Console.SetCursorPosition(player[0, j], player[0, j]);
                                    Console.WriteLine(" ");
                                    player[0, j]++;
                                }
                            }
                            else if (player[0, 0] + 1 == player[0,0] && player[0, 0] + 2 <= 49)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    Console.SetCursorPosition(player[0, k], player[0, k]);
                                    Console.WriteLine(" ");
                                    player[0, k] += 2;
                                }
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            Console.SetCursorPosition(player[0, k], player[0, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (player[0, 3] < 11)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Console.SetCursorPosition(player[0, j], player[0, j]);
                                Console.WriteLine(" ");
                                player[0, j]++;
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            Console.SetCursorPosition(player[0, k], player[0, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    default:
                        break;
                }
            } while (key != ConsoleKey.Enter);
        }
        public static void SecondShipCoord4( )
        {
            //Console.SetCursorPosition(0, 19);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Set Your 4* SHIP and Press [Enter]");
            Random random = new Random();
            int r;
            do
            {
                r = random.Next(36, 50);
            } while (r == player[0,0] || r == player[0, 0]);
            for (int i = 0; i < 4; i++)
            {
                player[1, i] = r;
                player[1, i] = i + 3;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(player[1, i], player[1, i]);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("*");
            }
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (player[1, 0] > 36)
                        {
                            if (player[1, 0] - 1 != player[0,0] && player[1, 0] - 1 != player[0, 0])
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    Console.SetCursorPosition(player[1, k], player[1, k]);
                                    Console.WriteLine(" ");
                                    player[1, k]--;
                                }
                            }
                            else if (player[1, 0] - 1 == player[0,0] || player[1, 0] - 1 == player[0, 0])
                            {
                                if (player[1, 0] - 2 != player[0,0] && player[1, 0] - 2 != player[0, 0] &&
                                player[1, 0] - 2 >= 36)
                                {
                                    for (int k = 0; k < 4; k++)
                                    {
                                        Console.SetCursorPosition(player[1, k], player[1, k]);
                                        Console.WriteLine(" ");
                                        player[1, k] -= 2;
                                    }
                                }
                                else if (player[1, 0] - 2 == player[0,0] || player[1, 0] - 2 == player[0, 0])
                                {
                                    if (player[1, 0] - 3 >= 36)
                                    {
                                        for (int k = 0; k < 4; k++)
                                        {
                                            Console.SetCursorPosition(player[1, k], player[1, k]);
                                            Console.WriteLine(" ");
                                            player[1, k] -= 3;
                                        }
                                    }
                                }
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            Console.SetCursorPosition(player[1, k], player[1, k]);
                            Console.WriteLine("*");
                        }


                        break;
                    case ConsoleKey.UpArrow:

                        if (player[1, 0] > 3)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Console.SetCursorPosition(player[1, j], player[1, j]);
                                Console.WriteLine(" ");
                                player[1, j]--;
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            Console.SetCursorPosition(player[1, k], player[1, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (player[1, 0] < 49)
                        {
                            if (player[1, 0] + 1 != player[0,0] && player[1, 0] + 1 != player[0, 0])
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    Console.SetCursorPosition(player[1, k], player[1, k]);
                                    Console.WriteLine(" ");
                                    player[1, k]++;
                                }
                            }
                            else if (player[1, 0] + 1 == player[0,0] || player[1, 0] + 1 == player[0, 0])
                            {
                                if (player[1, 0] + 2 != player[0,0] && player[1, 0] + 2 != player[0, 0] &&
                                player[1, 0] + 2 <= 49)
                                {
                                    for (int k = 0; k < 4; k++)
                                    {
                                        Console.SetCursorPosition(player[1, k], player[1, k]);
                                        Console.WriteLine(" ");
                                        player[1, k] += 2;
                                    }
                                }
                                else if (player[1, 0] + 2 == player[0,0] || player[1, 0] + 2 == player[0, 0])
                                {
                                    if (player[1, 0] + 3 <= 49)
                                    {
                                        for (int k = 0; k < 4; k++)
                                        {
                                            Console.SetCursorPosition(player[1, k], player[1, k]);
                                            Console.WriteLine(" ");
                                            player[1, k] += 3;
                                        }
                                    }
                                }
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            Console.SetCursorPosition(player[1, k], player[1, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (player[1, 3] < 11)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                Console.SetCursorPosition(player[1, k], player[1, k]);
                                Console.WriteLine(" ");
                                player[1, k]++;
                            }
                        }
                        for (int k = 0; k < 4; k++)
                        {
                            Console.SetCursorPosition(player[1, k], player[1, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    default:
                        break;
                }
            } while (key != ConsoleKey.Enter);
        }
        public static void FirstShipCoord3()
        {
            Console.SetCursorPosition(0, 19);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Set Your 3* SHIP and Press [Enter]");
            Random random = new Random();
            int r;
            do
            {
                r = random.Next(36, 50);
            } while (r == player[0,0] || r == player[0, 0] || r == player[1, 0]);
            for (int i = 0; i < 3; i++)
            {
                player[0, i] = r;
                player[0, i] = i + 3;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(player[0, i], player[0, i]);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("*");
            }
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (player[0, 0] > 36)
                        {
                            if (player[0, 0] - 1 != player[0,0] && player[0, 0] - 1 != player[0, 0] && player[0, 0] - 1 != player[1, 0])
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    Console.SetCursorPosition(player[0, k], player[0, k]);
                                    Console.WriteLine(" ");
                                    player[0, k]--;
                                }
                            }
                            else if (player[0, 0] - 1 == player[0,0] || player[0, 0] - 1 == player[0, 0] || player[0, 0] - 1 == player[1, 0])
                            {
                                if (player[0, 0] - 2 != player[0,0] && player[0, 0] - 2 != player[0, 0] && player[0, 0] - 2 != player[1, 0] &&
                                player[0, 0] - 2 >= 36)
                                {
                                    for (int k = 0; k < 3; k++)
                                    {
                                        Console.SetCursorPosition(player[0, k], player[0, k]);
                                        Console.WriteLine(" ");
                                        player[0, k] -= 2;
                                    }
                                }
                                else if (player[0, 0] - 2 == player[0,0] || player[0, 0] - 2 == player[0, 0] || player[0, 0] - 2 == player[1, 0])
                                {
                                    if (player[0, 0] - 3 != player[0,0] && player[0, 0] - 3 != player[0, 0] && player[0, 0] - 3 != player[1, 0] && player[0, 0] - 3 >= 36)
                                    {
                                        for (int k = 0; k < 3; k++)
                                        {
                                            Console.SetCursorPosition(player[0, k], player[0, k]);
                                            Console.WriteLine(" ");
                                            player[0, k] -= 3;
                                        }


                                    }
                                    else if (player[0, 0] - 3 == player[0,0] || player[0, 0] - 3 == player[0, 0] || player[0, 0] - 3 == player[1, 0])
                                    {
                                        if (player[0, 0] - 4 >= 36)
                                        {
                                            for (int k = 0; k < 3; k++)
                                            {
                                                Console.SetCursorPosition(player[0, k], player[0, k]);
                                                Console.WriteLine(" ");
                                                player[0, k] -= 4;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(player[0, k], player[0, k]);
                            Console.WriteLine("*");
                        }


                        break;
                    case ConsoleKey.UpArrow:

                        if (player[0, 0] > 3)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.SetCursorPosition(player[0, j], player[0, j]);
                                Console.WriteLine(" ");
                                player[0, j]--;
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(player[0, k], player[0, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (player[0, 0] < 49)
                        {
                            if (player[0, 0] + 1 != player[0,0] && player[0, 0] + 1 != player[0, 0] && player[0, 0] + 1 != player[1, 0])
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    Console.SetCursorPosition(player[0, k], player[0, k]);
                                    Console.WriteLine(" ");
                                    player[0, k]++;
                                }
                            }
                            else if (player[0, 0] + 1 == player[0,0] || player[0, 0] + 1 == player[0, 0] || player[0, 0] + 1 == player[1, 0])
                            {
                                if (player[0, 0] + 2 != player[0,0] && player[0, 0] + 2 != player[0, 0] && player[0, 0] + 2 != player[1, 0] &&
                                player[0, 0] + 2 <= 49)
                                {
                                    for (int k = 0; k < 3; k++)
                                    {
                                        Console.SetCursorPosition(player[0, k], player[0, k]);
                                        Console.WriteLine(" ");
                                        player[0, k] += 2;
                                    }
                                }
                                else if (player[0, 0] + 2 == player[0,0] || player[0, 0] + 2 == player[0, 0] || player[0, 0] + 2 == player[1, 0])
                                {
                                    if (player[0, 0] + 3 != player[0,0] && player[0, 0] + 3 != player[0, 0] && player[0, 0] + 3 != player[1, 0] && player[0, 0] + 3 <= 49)
                                    {
                                        for (int k = 0; k < 3; k++)
                                        {
                                            Console.SetCursorPosition(player[0, k], player[0, k]);
                                            Console.WriteLine(" ");
                                            player[0, k] += 3;
                                        }
                                    }
                                    else if (player[0, 0] + 3 == player[0,0] || player[0, 0] + 3 == player[0, 0] || player[0, 0] + 3 == player[1, 0])
                                    {
                                        if (player[0, 0] + 4 <= 49)
                                        {
                                            for (int k = 0; k < 3; k++)
                                            {
                                                Console.SetCursorPosition(player[0, k], player[0, k]);
                                                Console.WriteLine(" ");
                                                player[0, k] += 4;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(player[0, k], player[0, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (player[0, 2] < 11)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                Console.SetCursorPosition(player[0, k], player[0, k]);
                                Console.WriteLine(" ");
                                player[0, k]++;
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(player[0, k], player[0, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    default:
                        break;
                }
            } while (key != ConsoleKey.Enter);
        }
        public static void SecondShipCoord3()
        {
            Console.SetCursorPosition(0, 19);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Set Your 3* SHIP and Press [Enter]");
            Random random = new Random();
            int r;
            do
            {
                r = random.Next(36, 50);
            } while (r == player[0,0] || r == player[0, 0] || r == player[1, 0] || r == player[0, 0]);
            for (int i = 0; i < 3; i++)
            {
                player[1, i] = r;
                player[1, i] = i + 3;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(player[1, i], player[1, i]);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("*");
            }
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (player[1, 0] > 36)
                        {
                            if (player[1, 0] - 1 != player[0,0] && player[1, 0] - 1 != player[0, 0] && player[1, 0] - 1 != player[1, 0] && player[1, 0] - 1 != player[0, 0])
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    Console.SetCursorPosition(player[1, k], player[1, k]);
                                    Console.WriteLine(" ");
                                    player[1, k]--;
                                }
                            }
                            else if (player[1, 0] - 1 == player[0,0] || player[1, 0] - 1 == player[0, 0] || player[1, 0] - 1 == player[1, 0] || player[1, 0] - 1 == player[0, 0])
                            {
                                if (player[1, 0] - 2 != player[0,0] && player[1, 0] - 2 != player[0, 0] && player[1, 0] - 2 != player[1, 0] && player[1, 0] - 2 != player[0, 0] &&
                                player[1, 0] - 2 >= 36)
                                {
                                    for (int k = 0; k < 3; k++)
                                    {
                                        Console.SetCursorPosition(player[1, k], player[1, k]);
                                        Console.WriteLine(" ");
                                        player[1, k] -= 2;
                                    }
                                }
                                else if (player[1, 0] - 2 == player[0,0] || player[1, 0] - 2 == player[0, 0] || player[1, 0] - 2 == player[1, 0] || player[1, 0] - 2 == player[0, 0])
                                {
                                    if (player[1, 0] - 3 != player[0,0] && player[1, 0] - 3 != player[0, 0] && player[1, 0] - 3 != player[1, 0] && player[1, 0] - 3 != player[0, 0] && player[1, 0] - 3 >= 36)
                                    {
                                        for (int k = 0; k < 3; k++)
                                        {
                                            Console.SetCursorPosition(player[1, k], player[1, k]);
                                            Console.WriteLine(" ");
                                            player[1, k] -= 3;
                                        }


                                    }
                                    else if (player[1, 0] - 3 == player[0,0] || player[1, 0] - 3 == player[0, 0] || player[1, 0] - 3 == player[1, 0] || player[1, 0] - 3 == player[0, 0])
                                    {
                                        if (player[1, 0] - 4 != player[0,0] && player[1, 0] - 4 != player[0, 0] && player[1, 0] - 4 != player[1, 0] && player[1, 0] - 4 != player[0, 0] && player[1, 0] - 4 >= 36)
                                        {
                                            for (int k = 0; k < 3; k++)
                                            {
                                                Console.SetCursorPosition(player[0, k], player[0, k]);
                                                Console.WriteLine(" ");
                                                player[1, k] -= 4;
                                            }
                                        }
                                        else if (player[1, 0] - 4 == player[0,0] || player[1, 0] - 4 == player[0, 0] || player[1, 0] - 4 == player[1, 0] || player[1, 0] - 4 == player[0, 0])
                                        {
                                            if (player[1, 0] - 5 != player[0,0] && player[1, 0] - 5 != player[0, 0] && player[1, 0] - 5 != player[1, 0] && player[1, 0] - 5 != player[0, 0] && player[1, 0] - 5 >= 36)
                                            {
                                                for (int k = 0; k < 3; k++)
                                                {
                                                    Console.SetCursorPosition(player[1, k], player[1, k]);
                                                    Console.WriteLine(" ");
                                                    player[1, k] -= 5;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(player[1, k], player[1, k]);
                            Console.WriteLine("*");
                        }


                        break;
                    case ConsoleKey.UpArrow:

                        if (player[1, 0] > 3)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.SetCursorPosition(player[1, j], player[1, j]);
                                Console.WriteLine(" ");
                                player[1, j]--;
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(player[1, k], player[1, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (player[1, 0] < 49)
                        {
                            if (player[1, 0] + 1 != player[0,0] && player[1, 0] + 1 != player[0, 0] && player[1, 0] + 1 != player[1, 0] && player[1, 0] + 1 != player[0, 0])
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    Console.SetCursorPosition(player[1, k], player[1, k]);
                                    Console.WriteLine(" ");
                                    player[1, k]++;
                                }
                            }
                            else if (player[1, 0] + 1 == player[0,0] || player[1, 0] + 1 == player[0, 0] || player[1, 0] + 1 == player[1, 0] || player[1, 0] + 1 == player[0, 0])
                            {
                                if (player[1, 0] + 2 != player[0,0] && player[1, 0] + 2 != player[0, 0] && player[1, 0] + 2 != player[1, 0] && player[1, 0] + 2 != player[0, 0] &&
                                player[1, 0] + 2 <= 49)
                                {
                                    for (int k = 0; k < 3; k++)
                                    {
                                        Console.SetCursorPosition(player[1, k], player[1, k]);
                                        Console.WriteLine(" ");
                                        player[1, k] += 2;
                                    }
                                }
                                else if (player[1, 0] + 2 == player[0,0] || player[1, 0] + 2 == player[0, 0] || player[1, 0] + 2 == player[1, 0] || player[1, 0] + 2 == player[0, 0])
                                {
                                    if (player[1, 0] + 3 != player[0,0] && player[1, 0] + 3 != player[0, 0] && player[1, 0] + 3 != player[1, 0] && player[1, 0] + 3 != player[0, 0] && player[1, 0] + 3 <= 49)
                                    {
                                        for (int k = 0; k < 3; k++)
                                        {
                                            Console.SetCursorPosition(player[1, k], player[1, k]);
                                            Console.WriteLine(" ");
                                            player[1, k] += 3;
                                        }


                                    }
                                    else if (player[1, 0] + 3 == player[0,0] || player[1, 0] + 3 == player[0, 0] || player[1, 0] + 3 == player[1, 0] || player[1, 0] + 3 == player[0, 0])
                                    {
                                        if (player[1, 0] + 4 != player[0,0] && player[1, 0] + 4 != player[0, 0] && player[1, 0] + 4 != player[1, 0] && player[1, 0] + 4 != player[0, 0] && player[1, 0] + 4 <= 49)
                                        {
                                            for (int k = 0; k < 3; k++)
                                            {
                                                Console.SetCursorPosition(player[0, k], player[0, k]);
                                                Console.WriteLine(" ");
                                                player[1, k] += 4;
                                            }
                                        }
                                        else if (player[1, 0] + 4 == player[0,0] || player[1, 0] + 4 == player[0, 0] || player[1, 0] + 4 == player[1, 0] || player[1, 0] + 4 == player[0, 0])
                                        {
                                            if (player[1, 0] + 5 != player[0,0] && player[1, 0] + 5 != player[0, 0] && player[1, 0] + 5 != player[1, 0] && player[1, 0] + 5 != player[0, 0] && player[1, 0] + 5 <= 49)
                                            {
                                                for (int k = 0; k < 3; k++)
                                                {
                                                    Console.SetCursorPosition(player[1, k], player[1, k]);
                                                    Console.WriteLine(" ");
                                                    player[1, k] += 5;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(player[1, k], player[1, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (player[1, 2] < 11)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                Console.SetCursorPosition(player[1, k], player[1, k]);
                                Console.WriteLine(" ");
                                player[1, k]++;
                            }
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            Console.SetCursorPosition(player[1, k], player[1, k]);
                            Console.WriteLine("*");
                        }

                        break;
                    default:
                        break;
                }
            } while (key != ConsoleKey.Enter);

        }
    }



    class ConsollAPP
    {


        static void Main(string[] args)
        {

            Battle_sea.MAIN();
           


        }
    }
}
