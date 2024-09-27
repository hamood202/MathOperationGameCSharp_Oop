using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationGame.Bl
{
     class LevelTwo :IMathOpretorLevel
    {
        public int LevelStart { get; } = 0;
        public int LevelEnd { get; } = 20;
        public int OpretorCount { get; } = 2;
        public int RightAnswerCount { get; } = 7;
        public int WongAnswerCount { get; } = 3;
        public int LevelNumber { get; } = 2;
        public IMathOpretorLevel GetNextLevel(int nRightAnswerCount, int nWrongAnswerCount)
        {
            LevelStatus status = LevelStatus.InProgress;
            if (nRightAnswerCount == RightAnswerCount)
            {
                Console.WriteLine("Level Pormoted");
                status = LevelStatus.Pormoted;
                return new LevelThree();
            }
            if (nWrongAnswerCount == WongAnswerCount)
            {
                Console.WriteLine("Game Over");
                status = LevelStatus.GameOver;

            }
            return new LevelTwo();

        }
        public MathOperator GetNextNumber()
        {
            Random myrandom = new Random();
            MathOperator currentNumber;
            currentNumber.nFirstNumber = myrandom.Next(LevelStart, LevelEnd);
            currentNumber.nSecondNumber = myrandom.Next(LevelStart, LevelEnd);
            currentNumber.nOperator = currentNumber.nOperator = myrandom.Next(1, OpretorCount);

            return currentNumber;
        }
    }
}
