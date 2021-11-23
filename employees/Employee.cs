using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employees
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Rate { get; set; }
        private const double BASIC_SALARY = 1000.0;

        public Employee()
        {
            Name = "No name";
            Age = 18;
            Rate = 1.0;
        }
        public Employee(string name, int age, double rate)
        {
            Name = name;
            Age = age;
            Rate = rate;
        }

        public override string ToString()
        {
            string basicInfo = "Name: " + Name + ", age: " + Age;
            return basicInfo;
        }

        public virtual double Salary
        {
            get { return Rate * BASIC_SALARY; }
        }
    }
}