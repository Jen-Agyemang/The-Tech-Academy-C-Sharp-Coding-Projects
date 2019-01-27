using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

            // 1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            //List<int> numbers = new List<int> { 2, 4, 5 };
            //foreach (int wholeNumber in numbers)
            //{
            //    Console.WriteLine(wholeNumber);
            //}
            
            //foreach (int wholeNumber in numbers)
            //{
            //    Console.WriteLine("Please select a number to divide by the numbers on the screen?");
            //    decimal numberSelected = Convert.ToDecimal(Console.ReadLine());
            //    Console.WriteLine("Dividing the numbers...");
            //    decimal numberDivision = numberSelected / wholeNumber;
            //    Console.WriteLine("The number selected is " + numberSelected + " when divided by " + wholeNumber + " equals " + numberDivision);
            //}
            //Console.ReadLine();

            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.

            //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.

            //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.

            //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

            try
            {
                List<int> numbers = new List<int> { 2, 4, 5, 0 };
                foreach (int wholeNumber in numbers)
                {
                    Console.WriteLine(wholeNumber);
                }

                foreach (int wholeNumber in numbers)
                {
                    Console.WriteLine("Please select a number to divide by the numbers on the screen?");
                    decimal numberSelected = Convert.ToDecimal(Console.ReadLine());
                    //
                    Console.WriteLine("Dividing the numbers...");
                    decimal numberDivision = wholeNumber / numberSelected;
                    Console.WriteLine("The number selected is " + numberSelected + " when divided by " + wholeNumber + " equals " + numberDivision);
                }
                Console.ReadLine();
            }
            catch (FormatException calculation)
            {
                Console.WriteLine("Please type in real numbers only.");
                Console.ReadLine();
                return;
            }
            catch (DivideByZeroException calculation)
            {
                Console.WriteLine("Please do not divide by zero");
                Console.ReadLine();
            }
            catch (Exception calculation)
            {
                Console.WriteLine(calculation.Message);
            }
            finally
            {
                Console.ReadLine();
            }







        }
    }
}
