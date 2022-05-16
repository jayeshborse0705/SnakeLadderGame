using System;

namespace SnackLadderGame
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to snake and ladder problem");
            SnakeAndLadder srating_Point = new SnakeAndLadder();
            int Position = srating_Point.StartPlay();
            RollingDie rollingDie = new RollingDie();
            int DiceNum = rollingDie.NumGenerator();
            Console.WriteLine("DiceNum={0}, Position={1}", DiceNum, +Position);
            CheckForOptioncs checkForOptioncs = new CheckForOptioncs();
            checkForOptioncs.CheckingOption(ref DiceNum, ref Position);
            Console.WriteLine("DiceNum={0}, Position={1}", DiceNum, +Position);
            PlayerPositionTill_100 position100 = new PlayerPositionTill_100();
            position100.Position100(ref DiceNum, ref Position);
            Console.WriteLine("DiceNum={0}, Position={1}", DiceNum, +Position);

        }


    }
}