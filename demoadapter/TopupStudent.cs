using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class TopupStudent : Student
    {
        public int Score { get; set; }
        public TopupStudent()
        {
            Score = 50;
        }

        public TopupStudent(string first, string last, int score) : base(first, last)
        {
            Score = score;
        }

        public override string GetGrade()
        {
            if (Score < 40) return "Fail";
            else if (Score < 60) return "Pass";
            else if (Score < 80) return "Merit";
            else return "Distinction";
        }
    }
}