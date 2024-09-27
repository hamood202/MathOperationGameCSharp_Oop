using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationGame
{
    public class ClsLevel
    {
        public ClsLevel() 
        {
          
        }
        public int LevelStart {  get; set; }
        public int LevelEnd { get; set; }
        public int OpretorCount { get; set; }
        public int RightAnswerCount { get; set; }
        public int WongAnswerCount { get; set; }
        public  MathOperator GetNextNumber()
        {

            Random myrandom = new Random();
            MathOperator currentNumber;
            currentNumber.nFirstNumber = myrandom.Next(LevelStart, LevelEnd);
            currentNumber.nSecondNumber = myrandom.Next(LevelStart, LevelEnd);
            currentNumber.nOperator = currentNumber.nOperator= myrandom.Next(1, OpretorCount);
     
            return currentNumber;
        }

    }
}
