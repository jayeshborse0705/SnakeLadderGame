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
                        Console.WriteLine("Going ahead by Ladder:" + Position);
                        if (Position > 100)
                        {
                            Position -= GenNumber;
                            Temp = 0;
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

        }
    }
}
