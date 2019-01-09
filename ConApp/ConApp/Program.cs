using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {


//            CREATE A CONSOLE APPLICATION THAT DOES THE FOLLOWING:
//1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).

//2.Takes an input from the user, adds 25 to it, and prints the result to the console.

//3.Takes an input from the user, divides it by 12.5, and prints the result to the console.

//4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.

//5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).




           //Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
           Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number chosen multiplies by fifty =" + num1 * 50);
            Console.ReadLine();


            // Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number chosen added to twenty five = " + (num2 + 25));
            Console.ReadLine();


            //Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.Write("Enter a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number chosen divides by 12.5 = " + num3 / 12.5);
            Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console
            Console.Write("Enter a number:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool comparison = true;
            Console.WriteLine("The number chosen greater than fifty = " +(num4 > 50));
            Console.ReadLine();


            // Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator)

            Console.Write("Enter a number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number chosen divides by seven = " + num5 / 7);
            Console.WriteLine("The remainder of the chosen number divides seven = " + num5 % 7);
            Console.ReadLine();


        }

    }
}
