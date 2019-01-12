using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
//            Your job is to create a console-based application for getting a shipping quote for a package.

//REQUIREMENTS
//The first line of the program must be: “Welcome to Package Express.Please follow the instructions below.”

//The user must then be prompted for the package weight.

//If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.

//The user must then be prompted for the package width.

//Then the package height.

//Then the package length.

//If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.

//The sum total of dimensions are then multiplied by the weight and divided by 100.

//The result of that calculation is the quote.

//Display the quote to the user as a dollar amount.

            

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            // string comparisonResult = packageWeight >= 50 ? "Package too heavy to be shipped via Package Express. Have a good day."; 
            // Console.WriteLine(comparisonResult);
            if (packageWeight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else if (packageWeight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine("Please Enter the package height:");
                Decimal packageHeight = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine("Please enter the package length:");
                Decimal packageLength = Convert.ToDecimal(Console.ReadLine());
                Console.ReadLine();

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }

                Console.WriteLine("Your estimated total for shipping this package is: " +"$" + (packageWidth + packageHeight + packageLength) * ( packageWeight) / (100) + " Thank you.");
                Decimal total = Convert.ToDecimal(Console.ReadLine());
            }




            Console.ReadLine();

        }
    }
}
