using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ClassExamplesProject
{
    class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int SAT { get; set; }
        public double GPA { get; set; }
        public int? MajorId { get; set; } //(?) means it can be null
    }
}
