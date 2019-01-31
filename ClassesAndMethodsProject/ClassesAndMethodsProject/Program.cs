using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class. In that class, create a method that takes two integers as parameters.Make one of them optional.Have the method do a math operation and return a integer result.

            //2. In the Main() method of the console app, instantiate the class.

            //3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.

            //4. Call the method in the class, passing in the one or two numbers entered.

            //5. Try various combinations of numbers on the code, including having no second number.

            MathOperation calc = new MathOperation();
            Console.WriteLine("Please, input two numbers, one at a time?");
            int numberSelected1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A second number is required, but please, this is an optional number.");
            int numberSelected2 = Convert.ToInt32(Console.ReadLine());
            int a = calc.Addition(numberSelected1);
            int b = calc.Addition(numberSelected2);
            Console.WriteLine((a + numberSelected1));
            Console.WriteLine((b + numberSelected2));
            Console.ReadLine();
        }
    }
}
