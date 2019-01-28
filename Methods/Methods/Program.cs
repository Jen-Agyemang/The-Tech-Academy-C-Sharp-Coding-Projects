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
              
            
                Console.WriteLine("Please, what number do you want to do the math operation on?");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Math calc = new Math();
                int a = calc.Add(numberOne);
                Console.WriteLine("The number for the math Addition is " + a + " and your chosen number is " + numberOne + ".");
                Console.WriteLine("Total equal " + (a + numberOne));
                
                Console.WriteLine("Please, what number do you want to do the math operation on?");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                int b = calc.Multiply(numberTwo);
                Console.WriteLine("The number for the math multiplication is " + b + "," +  " and your chosen number is " + numberTwo + ".");
                Console.WriteLine("Total equal " + (b * numberTwo));
                
                Console.WriteLine("Please, what number do you want to do the math operation on? ");
                int numberThree = Convert.ToInt32(Console.ReadLine());
                int c = calc.Subtract(numberThree);
                Console.WriteLine("The number for the math subtraction is " + c + "," + " and your chosen number is " + numberThree + ".");
                Console.WriteLine("Total equal " + (c - numberThree));
                Console.ReadLine();

            }
          

        }
       
        
    }
}
