using System;

namespace ClassExamplesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var cls1 = new Class("English", 101, null);
            Console.WriteLine($"{cls1.Id}, {cls1.Subject}");

            var cls2 = new Class("Basket Weaving", 901, null);
            Console.WriteLine($"{cls2.Id}, {cls2.Subject}");

            var business = new Major();
            business.Id = 1;
            business.Description = "General Business";
            //business.MinSAT = 800;
            business.SetMinSAT(900);

            var accounting = new Major();
            accounting.Id = 2;
            accounting.Description = "Accounting";
            accounting.SetMinSAT(1000);

            var Finance = new Major(3, "Finance", 1100);

            Console.WriteLine($"minsat is {Finance.MinSAT}");

            var std1 = new Student();
            std1.Id = 1;
            std1.Firstname = "Noah";
            std1.Lastname = "Phence";
            std1.GPA = 2.7;
            std1.SAT = 1200;
            std1.MajorId = business.Id;
            std1.Major = business;

         //print off first and last name w/ major description
            Console.WriteLine($"Name is {std1.Fullname()} majors in {std1.Major.Description}");
        }
    }
}
