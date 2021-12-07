using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class HighschoolStudent
    {
        public string Name { get; set;}
        public double Math { get; set; }
        public double English { get; set; }

        public HighschoolStudent()
        {
            Name = "No name";
            Math = 5.0;
            English = 5.0;
        }
        public HighschoolStudent(string name, double math, double english)
        {
            Name = name;
            Math = math;
            English = english;
        }

        public double GetAverage() 
        {
            return (Math + English) / 2.0;
        }
    }
}