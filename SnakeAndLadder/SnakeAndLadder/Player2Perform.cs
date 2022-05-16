using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class Player1Performs
    {
        public void Player1(ref int DiceUsed1, ref int Position1)
        {

            for (int i = 0; i < 1; i++)
            {
                int LadderNum = 1;
                //int a = 1;
                if (Position1 < 100)
                {
                    //a++;
                    Random Play = new Random();
                    int Temp = 1;
                    int GenNumber = Play.Next(1, 7);
                    DiceUsed1++;
                    Console.WriteLine("Generated number: " + GenNumber);
                    int Temporary = GenNumber;
                    int CheckNum = Play.Next(0, 3);
                    Console.WriteLine("You got Checking option number: " + CheckNum);

                    switch (CheckNum)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            Console.WriteLine("Your position is still in: " + Position1);
                            break;
                        case 1:
                            Position1 += GenNumber;
                            if (Position1 > 100)
                            {
                                Position1 -= GenNumber;
                                Temp = 0;
                                Console.WriteLine("Going ahead by Ladder:" + Position1);

                            }
                            else
                            {
                                Console.WriteLine("Going ahead by Ladder:" + Position1);
                            }
                            break;
                        default:
                            Position1 -= GenNumber;
                            if (Position1 < 0)
                            {
                                Position1 = 0;
                            }
                            Console.WriteLine("Snake bites and your position:" + Position1);
                            break;
                    }
                    if (LadderNum == GenNumber)
                    {
                        int GenNumber1 = Play.Next(1, 7);
                        DiceUsed1++;
                        Console.WriteLine("\nGenerated number due to LADDER: " + GenNumber1);
                        int CheckNum2 = Play.Next(0, 3);
                        Console.WriteLine("\nYou got Checking option number: " + CheckNum2);
                        Console.WriteLine("\nYou got a LADDER number and generates a number: " + CheckNum2);


                        switch (CheckNum2)
                        {
                            case 0:
                                Console.WriteLine("No Play");
                                Console.WriteLine("Your position is still in: " + Position1);
                                break;
                            case 1:
                                Position1 += GenNumber;
                                if (Position1 > 100)
                                {
                                    Position1 -= GenNumber;
                                    Temp = 0;
                                    Console.WriteLine("Going ahead by Ladder:" + Position1);

                                }
                                else
                                {
                                    Console.WriteLine("Going ahead by Ladder:" + Position1);
                                }
                                break;
                            default:
                                Position1 -= GenNumber;
                                if (Position1 < 0)
                                {
                                    Position1 = 0;
                                }
                                Console.WriteLine("Snake bites and your position:" + Position1);
                                break;
                        }

                    }
                    if (Temp == 0)
                        break;
                }
                else if (Position1 == 100)

                {
                    //Console.WriteLine("a is used {0} times:", a);
                    Console.WriteLine("Die is used {0} times:", DiceUsed1);
                    Console.WriteLine("Congratulation! You WON");

                }
            }
        }
    }
}