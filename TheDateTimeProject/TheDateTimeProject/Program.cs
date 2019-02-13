using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Prints the current date and time to the console.
            //2.Asks the user for a number.
            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Please, select a number?");
            int numberSelected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2} ", now, numberSelected, now.AddHours(numberSelected));
            Console.ReadLine(); 
        }
    }
}
