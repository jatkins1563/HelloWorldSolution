using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarah = new Student();
            sarah.Firstname = "Sarah";
            sarah.Lastname = "George";
            sarah.SetHireDate(2017, 6, 26);

            var chuck = new Student();
            chuck.Firstname = "Chuck";
            chuck.Lastname = "Traylor";

            var mattea = new Student();
            mattea.Firstname = "Mattea";
            mattea.Lastname = "Swain";

            sarah.Print();
            chuck.Print();
            mattea.Print();

            //var company = "TQL";
            //var student = "John";
            //var tenure = 7;

            //Console.WriteLine($"Welcome back, Commander, from {company}!");
            //Console.WriteLine($"My name is {student} and I have been at TQL for {tenure} months.");
            //Console.WriteLine();
        }
    }
}
