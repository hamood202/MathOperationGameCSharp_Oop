using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationGame.Bl
{
    public interface IMathOpretorLevel
    {
        public int LevelNumber { get;}
        public int LevelStart { get;  }
        public int LevelEnd { get; }
        public int OpretorCount { get; }
        public int RightAnswerCount { get; }
        public int WongAnswerCount { get; }
        public MathOperator GetNextNumber();
        public IMathOpretorLevel GetNextLevel(int nRightAnswerCount, int nWrongAnswerCount);
    }
}
