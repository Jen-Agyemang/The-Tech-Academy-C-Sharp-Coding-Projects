using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");


            Console.WriteLine("Person 1");
            int hourly1 = 15;
            Console.WriteLine("Hourly Rate:" + hourly1);
            int hoursWorked = 40;
            Console.WriteLine("Hours worked per week:" +hoursWorked);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            int hourly2 = 17;
            Console.WriteLine("Hourly rate:" + hourly2);
            int hoursworked2 = 32;
            Console.WriteLine("Hours worked per week:" + hoursworked2);
            Console.ReadLine();

            int annualSalary1 = 28800;
            Console.WriteLine("Annual Salary of Person 1: " + annualSalary1);
            Console.ReadLine();

            int annualSalary2 = 26112;
            Console.WriteLine("Annual Salary of Person 2: " + annualSalary2);
            Console.ReadLine();

            bool comparison = true;
            Console.WriteLine("Does Person 1 make more money than Person 2?" + comparison);

            Console.ReadLine();


        }
    }
}
