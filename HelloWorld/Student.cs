using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Active { get; set; }
        private DateTime HireDate { get; set; }

        public void SetHireDate(int year, int month, int day)
        {
            if(year < 1950 || year > 2200)
            {
                Console.WriteLine($"Year must be between 1950 and 2200.");
                return;
            }
            if(month < 1 || month > 12)
            {
                Console.WriteLine($"Do you know what a calendar is???? (Invalid month entered!)");
                return;
            }
            if(day < 1 || day > 31)
            {
                Console.WriteLine($"Thirty days have September, April, June, and November. (Invalid day entered!)");
            }
            HireDate = new DateTime(year, month, day);
        }

        public void Print()
        {
            Console.WriteLine($"{Firstname} {Lastname} - Hired: {HireDate.ToString("MM/dd/yyyy")}");

        }
    }
}
