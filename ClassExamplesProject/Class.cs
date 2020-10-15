using System;
using System.Collections.Generic;
using System.Text;
//When they are gray, it means you aren't using them yet
namespace ClassExamplesProject
{
    class Class
    {
        private static int NextId = 1;//this is a field

        public int Id { get; private set; }//this is a property
        public string Subject {get; set;}
        public int Section { get; set; }
        public int? InstructorId { get; set; }

        //method that doesn't return a value/ shortcut for ConsoleWriteline
        public void print()
        {
            Console.WriteLine($"Class: Id:{this.Id}, Subject: {this.Subject}, " +
                $"Section: {this.Section}, InstructorId: {this.InstructorId}");
        }

        //constructor that takes 3 parameters 
        public Class(string subject, int section, int? instructorId)
        {
            this.Id = NextId++;//this makes each one unique
            this.Subject = subject;
            this.Section = section;
            this.InstructorId = instructorId;
        }


        //default constructor: a contructor that takes no parameters
        //good practice to always have a default constructor
        public Class()
        {
        }
    }
}
