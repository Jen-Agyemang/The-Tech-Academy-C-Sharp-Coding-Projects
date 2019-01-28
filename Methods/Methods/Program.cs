using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
       { 
            //1.Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.

            //2. In the Main() program, ask the user what number they want to do the math operations on.

            //3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

            {
                Console.WriteLine("Please, what number do you want to do the addition operation on?");
                int numberSelected = Convert.ToInt32(Console.ReadLine());
                Math calc = new Math();
                int a = calc.Add(2, 2);
                int b = calc.Add(2, 2);
                Console.WriteLine("The number for the math adition is " + (a + b) + "," + " and your chosen number is " + numberSelected + ".");
                Console.WriteLine("Total equal " + ( a +  b + numberSelected));
                Console.ReadLine();
            }
          
            {
                Console.WriteLine("Please, what number do you want to do the multiplication operation on?");
                int numberSelected = Convert.ToInt32(Console.ReadLine());
                Math calc = new Math();
                int a = calc.Multiply(2, 2);
                int b = calc.Multiply(2, 2);
                Console.WriteLine("The number for the math multiplication is " + a * b  + "," +" and your chosen number is " + numberSelected + ".");
                 Console.WriteLine("Total equal " + a * b * numberSelected);
                Console.ReadLine();
            }

            {
                Console.WriteLine("Please, what number do you want to do the math operation on?");
                int numberSelected = Convert.ToInt32(Console.ReadLine());
                Math calc = new Math();
                int a = calc.Subtract(10, 4);
                int b = calc.Subtract(2, 1);
                Console.WriteLine("The number for the math subtraction is " + (a - b) + "," + " and your chosen number is " + numberSelected + ".");
                Console.WriteLine("Total equal " + (a - b - numberSelected));
                Console.ReadLine();
            }

            {
                //Other ways that I thought of doing the assignment
                //Console.WriteLine("Please, what number do you want to do the math operation on?");
                //int numberSelected = Convert.ToInt32(Console.ReadLine());
                //Math calc = new Math();
                //int y = calc.Subtract(10, 4);
                //Console.WriteLine("The number for the math subtraction is " + (y - numberSelected) + ".");
                //Console.WriteLine("Total equal " + (y - numberSelected));
                //Console.ReadLine();
            }
          

        }
       
        
    }
}
