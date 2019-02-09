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
            List<string> employees = new List<string>(); //{ "Jen Doe", "Martin Key", "Addy Molly", "Rich richy", "Max maxy", "Charley charles", "Mercy Pomaah", "Bigail Bigail", "Joe Mo", "Joe Tag" };
            employees.Add("Jen Doe");
            employees.Add("Martin Key");
            employees.Add("Addy Molly");
            employees.Add("Rich Richy");
            employees.Add("Max maxy");
            employees.Add("Charley charles");
            employees.Add("Mercy Pomaah");
            employees.Add("Bigail Bigai");
            employees.Add("Joe Mo");
            employees.Add("Joe Tag");


            foreach (string employee in employees)
            {
               Console.WriteLine(employee);
                Console.ReadLine();
            }
        }
    }
}
