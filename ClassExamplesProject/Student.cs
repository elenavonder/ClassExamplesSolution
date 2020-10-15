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
        //(?) means those that CAN'T be null CAN be null
        public int? MajorId { get; set; }
        public Major Major { get; set; }

        //this is a method returning a value
        public string Fullname ()
        {
            var fullname = $"{this.Lastname}, {this.Firstname}";
            return fullname;
        }
    }
}
