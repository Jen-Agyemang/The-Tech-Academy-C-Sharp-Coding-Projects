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
            //1.Make the Employee class take a generic type parameter.

            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

            //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.

            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.

            //5. Create a loop that prints all of the Things to the Console.

            Employees<string> things1 = new Employees<string>();
            things1.Things = new List<string>() { "Cars", "trucks", "animals" };
            Employees<int> things2 = new Employees<int>();
            things2.Things = new List<int>() { 2, 4, 6, };
            foreach (string items1 in things1.Things)
            {
                Console.WriteLine(items1);
            }
            foreach (int items2 in things2.Things)
            {
                Console.WriteLine(items2);
            }
            Console.ReadLine();

        }
        //Employees employee1 = new Employees();
        //Employees employee2 = new Employees();
        //employee1.Firstname = "Nana";
        //employee1.Lastname = "Jen";
        //employee2.Firstname = "Nana";
        //employee2.Lastname = "Jen";
        //employee1.Id = "93982389";
        //employee2.Id = "32891332";
        //Console.WriteLine("Does employee1 and employee2 have the same firstnames? " + (employee1.Firstname == employee2.Firstname));
        //Console.WriteLine("Does employee1 and employee2 have same lastnames? " + (employee1.Lastname == employee2.Lastname));
        //Console.WriteLine( (employee1 == employee2));
    }
}
