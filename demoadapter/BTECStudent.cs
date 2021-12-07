using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class BTECStudent : Student
    {
        private string grade;
        public BTECStudent()
        {
            grade = "Pass";
        }

        public BTECStudent(string first, string last, string grade) 
                                                          : base(first, last)
        {
            this.grade = grade;
        }

        public override string GetGrade()
        {
            return grade;
        }

    }
}