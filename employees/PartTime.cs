using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employees
{
    public class PartTime : Employee
    {
        // TODO:
        // Inherits from Employee
        // Declare property DaysOfWeek
        // Implement default constructor (DaysOfWeek = 2)
        // Implement parameter constructor (name, age, rate, days)
        // Override property Salary => rate * BS * DaysOfWeek / 5
        // Override method ToString (to print Days of week)
        public int DaysOfWeek { get; set; }
        public PartTime()
        {
            DaysOfWeek = 2;
        }

        public PartTime(string name, int age, double rate, int days) : base(name, age, rate)
        {
            DaysOfWeek = days;
        }

        public override double Salary
        {
            get 
            {
                return base.Salary * DaysOfWeek / 5;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", working days: " + DaysOfWeek;
        }
    }
}