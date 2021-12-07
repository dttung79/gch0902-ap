using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public abstract class Student
    {
        protected string firstName;
        protected string lastName;

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Student()
        {
            FirstName = "No";
            LastName = "Name";
        }
        public Student(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        public abstract string GetGrade();
    }
}