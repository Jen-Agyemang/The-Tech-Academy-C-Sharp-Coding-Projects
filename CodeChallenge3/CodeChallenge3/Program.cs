using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Code Challenge Practice
            //1. Given An Array Of Integers, Write A Method To Total The Odd Numbers
           

            int i = 0;
            //declaring array of integers
            int[] myOddArray = new int[5];

            //reading the elements
            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < myOddArray.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                myOddArray[i] = int.Parse(Console.ReadLine());
            }

            //checking and printing all odd numbers
            Console.WriteLine("List of odd  numbers : ");
            for (i = 0; i < myOddArray.Length; i++)
            {
                //condition to check ODD number
                if (myOddArray[i] % 2 != 0)
                    Console.Write(myOddArray[i] + " ");
            }
            Console.ReadLine();

            //2. Given an array of integers, write a method to sum the elements in the array knowing that some of the elements may be very large integers

            int[] numbers = new int[] { 125, 100, 255, 500, 85 };
            int total = numbers.Sum();
            Console.WriteLine(total);
            Console.ReadLine();


            //3. Given A String, Reverse It

            string countries = "Ghana, USA, Canada ";
            char[] array = countries.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
            Console.ReadLine();

            //4. Given A String, Remove Any Repeated Words

            string duplicateString = "car, car, bike, ship, bike, skoter, ship, boat";
            var nonDuplicateString = string.Join(" ", duplicateString.Split(' ').Distinct());
            Console.WriteLine(nonDuplicateString);



            //5. FizzBuzz

            for (int k = 1; k <= 15; k++)
            {
                if (k % 3 == 0 && k % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (k % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (k % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(k);
                }
            }
            Console.ReadLine();


        }
    }
}
