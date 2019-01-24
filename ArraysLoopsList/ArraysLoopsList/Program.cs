using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLoopsList
{
    class Program
    {
        static void Main(string[] args)
        {
            //            IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:



            //// 1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each string in the Array, adding the user’s text to the string.Then create a loop that prints off each string in the Array on a separate line.
            string[] countries = { "Ghana", "Nigeria", "Togo", "Benin", "Niger", "Saychelles", "Madagascar" };
            Console.WriteLine("Input a text?");
            string inputCountry = (Console.ReadLine());
            foreach ( string country in countries)
            {

               {

                    Console.WriteLine(country + " " + inputCountry );



                }

            }

            Console.ReadLine();


            //2.Create an infinite loop.

            //for(; ; )
            //{
            //    Console.WriteLine("Infinite loop");

            //}


            //Another example of infinite loop

           //for (int i = 0; i < 5;)
            //{
            //    Console.WriteLine(i);
            //}


            // 3.Fix the infinite loop so it will execute.
            for (int i = 0; i < 5; i++)
            {
               Console.WriteLine(i);
            }
            Console.ReadLine();

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            int days = 7;
             for (int i = 0; i < 7; i++) 
            {
               Console.WriteLine(days);
            }
            Console.ReadLine();


            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            int number = 20;
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();



            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.

            List<string> beaches = new List<string> { "La Palm Royal", "Koklobite", "Royal Senkye", "Sogakope Spa and Resort" };
            for (int d = 0; d < beaches.Count; d++)
            {
                Console.WriteLine(beaches[d]);
            }
            Console.WriteLine("Please select any?");
            string Selected = (Console.ReadLine());

            //Conditional Statement

            if (beaches.Contains((Selected)))
            {
                Console.WriteLine("You Selected " + Selected + " and it's index is " + beaches.IndexOf(Selected) + ".");
            }

            else if (!beaches.Contains(Selected))
            {
               Console.WriteLine("Does not exist.Try again.");

            }

            Console.ReadLine();


            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //8.Add code to that above loop that stops it from executing once a match has been found.



            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            List<string> animals = new List<string> { "Bobcats", "Rabbits", "Rabbits", "Bobcats", };
            //conditional statement
            foreach (string animal in animals)
                Console.WriteLine(animal);
                Console.WriteLine("Please select any?");
                string animalSelected = (Console.ReadLine());
            int pets = 0;
            foreach (string animal in animals)
            {
                if (animalSelected == animal)
                {
                    Console.WriteLine("You Selected " + animalSelected + " and it's index is " + animals.IndexOf(animalSelected) + ".");
                    pets += 1;
                }

            }
            if (pets == 0) 
            {
                Console.WriteLine("Does not exist");
            }



            Console.ReadLine();









            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.




            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

            List<string> places = new List<string>();
            List<string> town = new List<string>();
            places.Add("Lynnwood");
            places.Add("Renton");
            places.Add("Kirkland ");
            places.Add("Renton");
            foreach (string place in places)
            {
                if (!town.Contains(place))
                {
                    town.Add(place);
                    Console.WriteLine(place);
                }
                else
                {
                    Console.WriteLine(place + " is already listed.");
                }
            }


            Console.ReadLine();






        }
    }
}
