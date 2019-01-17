using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            //   IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:




            //3.Add in a message that displays when the user selects an index that doesn’t exist.


            //   1.Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            String[] stringArray = { "Africa", "Europe", "America", "Asia", "Australia", "Antartica"};
            Console.WriteLine("Select an index between 0 and 5?");
            int indexSelected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The index selected is " + stringArray[indexSelected] +".");
            Console.ReadLine();


            //2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

            int[] intArray = { 500, 6000, 200, 4000, 5000, 0, 34, 21, 49, 60 };
            Console.WriteLine("Select an index between 0 and 9?");
            int indexSelected1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The index selected is " + intArray[indexSelected1]);
            Console.ReadLine();


            //3.Add in a message that displays when the user selects an index that doesn’t exist.



            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

            List<string> stringList = new List<string>();
            stringList.Add("Nana");
            stringList.Add("Jen");
            stringList.Add("Agyemang");
            stringList.Add("Saychae");
            stringList.Add("Asantewaa");
            stringList.Add("Serwaah");

            Console.WriteLine("Select an index between 0 and 5?");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number selected is " + stringList[stringIndex] + ".");
            Console.ReadLine();








        }
    }
}
