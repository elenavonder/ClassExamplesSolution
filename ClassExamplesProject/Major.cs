using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamplesProject
{
    class Major
    {
        public int Id { get; set; }
        public string Description { get; set; }
        //MinSAT set to private so the user can't set own number
        public int MinSAT { get; private set; } 

        //method to set MinSAT so there isn't a invalid input
        public void SetMinSAT(int minsat)
        {
            if (minsat < 400 || minsat > 1600)
            {
                //this is an error
                Console.WriteLine($"ERROR minsat outside bounds");
                return;
            }
            this.MinSAT = minsat;
        }

        //constructor requring 3 parameters
        public Major(int id, string desc, int MinSAT)
        {
            this.Id = id;
            this.Description = desc;
            this.MinSAT = 400;//can put invalid number in
            this.SetMinSAT(MinSAT);//only valid input
        }

        //default constructor
        public Major()
        {
        }
    }
}
