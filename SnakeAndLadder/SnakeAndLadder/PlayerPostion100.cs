using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class PlayerPositionTill_100
    {

        public void Position100(ref int DiceNum, ref int Position)
        {
            while (Position < 100)
            {
                Random Check = new Random();
                int Temp = 1;
                Random Play = new Random();
                int GenNumber = Play.Next(1, 7);
                Console.WriteLine("\nGenerated number: " + GenNumber);
                DiceNum = GenNumber;
                int CheckNum = Check.Next(0, 3);
                Console.WriteLine("\nYou got Checking option number: " + CheckNum);

                switch (CheckNum)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        Console.WriteLine("Your position is still in: " + Position);
                        break;
                    case 1:
                        Position += GenNumber;
                        if (Position > 100)
                        {
                            Position -= GenNumber;
                            Temp = 0;
                            Console.WriteLine("Going ahead by Ladder:" + Position);

                        }
                        else
                        {
                            Console.WriteLine("Going ahead by Ladder:" + Position);
                        }
                        break;
                    default:
                        Position -= GenNumber;
                        if (Position < 0)
                        {
                            Position = 0;
                        }
                        Console.WriteLine("Snake bites and your position:" + Position);
                        break;



                }
                if (Temp == 0)
                    break;
            }
            if (Position == 100)
            {
                Console.WriteLine("Congratulation! You WON");
            }
            else if (Position < 100)
            {
                while (Position != 100)
                {
                    //a++;
                    Random Play1 = new Random();
                    int Dice_Num = Play1.Next(1, 7);
                    Position = Position + Dice_Num;
                    if (Position > 100)
                    {
                        Position = Position - Dice_Num;
                    }
                    Console.WriteLine("\nGenerated number: " + Dice_Num);
                    Console.WriteLine("Position of the Ludo guti:" + Position);
                    if (Position == 100)
                    {
                        Console.WriteLine("Congratulation! You WON");
                    }
                }
            }
        }
    }
}