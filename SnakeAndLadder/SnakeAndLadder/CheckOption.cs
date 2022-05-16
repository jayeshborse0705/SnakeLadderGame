using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class CheckForOptioncs
    {
        public void CheckingOption(int DiceNum, int StartPoint)
        {
            Random Check = new Random();
            int CheckNum = Check.Next(1, 3);
            Console.WriteLine("You got Checking option number: " + CheckNum);
            switch (CheckNum)
            {
                case 1:
                    Console.WriteLine("No Play");
                    break;
                case 2:
                    StartPoint += DiceNum;
                    Console.WriteLine("Going ahead by Ladder:" + StartPoint);
                    break;
                default:
                    StartPoint -= DiceNum;
                    Console.WriteLine("Snake bites:" + StartPoint);
                    break;
            }
        }
    }
}