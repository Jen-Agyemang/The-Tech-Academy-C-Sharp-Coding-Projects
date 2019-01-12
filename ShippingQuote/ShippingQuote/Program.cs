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
