using System;
using MathOperationGame.Bl;
namespace MathOperationGame
{
    public struct MathOperator
    {
      public  int nFirstNumber ;
      public  int nSecondNumber;
      public  int nOperator    ;
    }
    public enum LevelStatus
    {
        InProgress=1,
        Pormoted =2,
        GameOver =3
    }  
    public class Program
    {
        public static IMathOpretorLevel GetLevelObject( int levelNumber )
        {
            IMathOpretorLevel oIMathOpretorLevel = new LevelOne();
            switch (levelNumber)
            {
                case 1:
                    oIMathOpretorLevel = new LevelOne();
                    break;
                case 2:
                    oIMathOpretorLevel = new LevelTwo();
                    break;
                case 3:
                    oIMathOpretorLevel = new LevelThree();
                    break;
                case 4:
                    oIMathOpretorLevel = new LevelFour();
                    break;
                case 5:
                    oIMathOpretorLevel = new LevelFive();
                    break;
            }
            return oIMathOpretorLevel;
        }
        //public static MathOperator GetNextNumber(int levelNumber,out ClsLevel oClsLevel)
        //{

        //    Random myrandom = new Random();
        //    MathOperator currentNumber;
        //    oClsLevel =new ClsLevel();
        //    switch (levelNumber)
        //    {
        //        case 1:
        //            oClsLevel.LevelStart = 0;
        //            oClsLevel.LevelEnd = 10;
        //            oClsLevel.OpretorCount = 1;
        //            oClsLevel.RightAnswerCount = 5;
        //            oClsLevel.WongAnswerCount = 3;
        //            break;
        //        case 2:
        //            oClsLevel.LevelStart = 0;
        //            oClsLevel.LevelEnd = 20;
        //            oClsLevel.OpretorCount = 2;
        //            oClsLevel.RightAnswerCount = 7;
        //            oClsLevel.WongAnswerCount = 3;
        //            break;
        //        case 3:
        //            oClsLevel.LevelStart = 0;
        //            oClsLevel.LevelEnd = 20;
        //            oClsLevel.OpretorCount = 3;
        //            oClsLevel.RightAnswerCount = 10;
        //            oClsLevel.WongAnswerCount = 4;
        //            break;
        //        case 4:
        //            oClsLevel.LevelStart = 0;
        //            oClsLevel.LevelEnd = 30;
        //            oClsLevel.OpretorCount = 3;
        //            oClsLevel.RightAnswerCount = 12;
        //            oClsLevel.WongAnswerCount = 5;
        //            break;
        //        case 5:
        //            oClsLevel.LevelStart = 0;
        //            oClsLevel.LevelEnd = 50;
        //            oClsLevel.OpretorCount = 3;
        //            oClsLevel.RightAnswerCount = 15;
        //            oClsLevel.WongAnswerCount = 5;
        //            break;
        //    }  
        //    return oClsLevel.GetNextNumber();
        //}
        public static bool CheckResult(MathOperator currentNumber, int Result)
        {
            bool isRightAnser = false;
            switch (currentNumber.nOperator)
            {
                case 1:
                    isRightAnser = (Result == currentNumber.nFirstNumber + currentNumber.nSecondNumber);
                    break;
                case 2:
                    isRightAnser = (Result == currentNumber.nFirstNumber - currentNumber.nSecondNumber);
                    break;
                case 3:
                    isRightAnser = (Result == currentNumber.nFirstNumber * currentNumber.nSecondNumber);
                    break;
            }
            return isRightAnser;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to math operator Test");

            char exit = 'a';          
            int nRightAnswerCount = 0;
            int nWrongAnswerCount = 0;
   
            IMathOpretorLevel MyCurrentLevel = GetLevelObject(1);
            while (exit!='e')
            {
                if(MyCurrentLevel==null)
                {
                    Console.WriteLine("Congratulation game over");
                    break;
                }
                bool isRightAnser = false;
                MathOperator currentNumber = MyCurrentLevel.GetNextNumber();

                Console.WriteLine($"Your Current Level is {MyCurrentLevel.LevelNumber}");
                Console.WriteLine($"first number {currentNumber.nFirstNumber} second number {currentNumber.nSecondNumber} operator is {currentNumber.nOperator}");
                Console.WriteLine("***************************************************************");
                Console.WriteLine("Please enter result");
                int Result = Convert.ToInt32(Console.ReadLine());

                isRightAnser=CheckResult(currentNumber, Result);

                if (isRightAnser)
                {
                    Console.WriteLine("Right Answer");
                    nRightAnswerCount++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    nWrongAnswerCount++;
                }             
                 MyCurrentLevel = MyCurrentLevel.GetNextLevel(nRightAnswerCount, nWrongAnswerCount);

                               
                Console.WriteLine("***************************************************************");
                Console.WriteLine("Please enter e for exsit or press any key");
                exit = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
