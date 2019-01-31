using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class. In that class, create a void method that takes two integers as parameters.Have the method do a math operation on the first integer and display the second integer to the screen.
            //2. In the Main() method of the console app, instantiate the class.
            //3. Call the method in the class, passing in two numbers.
            //4. Call the method in the class, specifying the parameters by name.

            //Math calc = new Math();
            //int myValue = 5;
            //int secondValue = 2;
            //calc.Operation(myValue, secondValue);
            //Console.WriteLine(myValue + secondValue);
            //Console.ReadLine();

            Math calc = new Math();
            calc.Operation(a: 2, b: 5);
        }
    }
}
