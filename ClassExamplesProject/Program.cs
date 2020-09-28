using System;

namespace ClassExamplesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var business = new Major();//Major is a constructor w/ no parameters
            business.Id = 1;
            business.Description = "General Business";
            business.MinSAT = 800;
            var accounting = new Major();
            accounting.Id = 2;
            accounting.Description = "Accounting";
            accounting.MinSAT = 1000;
            var 

            var std1 = new Student();
            std1.Id = 1;
            std1.Firstname = "Noah";
            std1.Lastname = "Phence";
            std1.GPA = 2.7;
            std1.SAT = 1200;
            std1.MajorId = null;
        }
    }
}
