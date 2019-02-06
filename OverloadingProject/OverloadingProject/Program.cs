using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee1 = new Employees();
            Employees employee2 = new Employees();
            employee1.Firstname = "Nana";
            employee1.Lastname = "Jen";
            employee2.Firstname = "Nana";
            employee2.Lastname = "Jen";
            employee1.Id = "93982389";
            employee2.Id = "32891332";
            Console.WriteLine("Does employee1 and employee2 have the same firstnames? " + (employee1.Firstname == employee2.Firstname));
            Console.WriteLine("Does employee1 and employee2 have same lastnames? " + (employee1.Lastname == employee2.Lastname));
            Console.WriteLine("Does employee1 and employee2 have the same Id? " + (employee1.Id == employee2.Id));
            Console.ReadLine();

        }
    }
}
