using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLambdaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Employees = new List<string>(); // { "Jen Doe", "Martin Key", "Addy Molly", "Rich richy", "Max maxy", "Charley charles", "Mercy Pomaah", "Bigail Bigail", "Joe Mo", "Joe Tag" };
            Employees.Add("Jen Doe");
            Employees.Add("Martin Key");
            Employees.Add("Addy Molly");
            Employees.Add("Rich Richy");
            Employees.Add("Max maxy");
            Employees.Add("Charley charles");
            Employees.Add("Mercy Pomaah");
            Employees.Add("Bigail Bigai");
            Employees.Add("Joe Mo");
            Employees.Add("Joe Tag");

            foreach (string employees in Employees)
            {
                Console.WriteLine(employees);
                Console.WriteLine(employees.Contains("Joe"));
                Console.ReadLine();

            }
           
        }

    }
}
