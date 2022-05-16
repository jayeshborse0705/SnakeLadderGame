using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class RollingDie
    {
        public void NumGenerator()
        {
            Random LudoNum = new Random();
            int Num = LudoNum.Next(1, 6);
            Console.WriteLine("You got the number: " +Num);
        }
    }
}
