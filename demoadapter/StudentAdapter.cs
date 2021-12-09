using System;

namespace demoadapter
{
    public class StudentAdapter : Student
    {
        private HighschoolStudent hs;

        public StudentAdapter(string name, double math, double english) 
        {
            this.hs = new HighschoolStudent(name, math, english);
            firstName = name;
            lastName = "";
        }

        public override string GetGrade()
        {
            double avg = hs.GetAverage();
            if (avg < 5.0) return "Fail";
            else if (avg < 7.0) return "Pass";
            else if (avg < 9.0) return "Merit";
            else return "Distinction";
        }
    }
}