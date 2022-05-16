using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class CheckForOptioncs
    {
        public void CheckingOption(ref int DiceUsed, ref int Position)
        {
            Random Check = new Random();
            int CheckNum = Check.Next(0, 3);
            Console.WriteLine("\nYou got Checking option number: " + CheckNum);
            Random Play = new Random();
            int GenNumber = Play.Next(1, 7);
            DiceUsed++;
            int Temp = GenNumber;
            Console.WriteLine("\nGenerated number: " + GenNumber);

            switch (CheckNum)
            {
                case 0:
                    Console.WriteLine("No Play");
                    Console.WriteLine("Your position is still in: " + Position);
                    break;
                case 1:

                    Position += GenNumber;
                    Console.WriteLine("Going ahead by Ladder:" + Position);
                    break;
                default:
                    Position -= GenNumber;
                    if (Position < 0)
                    {
                        Position = 0;
                    }
                    Console.WriteLine("Snake bites:" + Position);
                    break;
            }

        }
    }
}
