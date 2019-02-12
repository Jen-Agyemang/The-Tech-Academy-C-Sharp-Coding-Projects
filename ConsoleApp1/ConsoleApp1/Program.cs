using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
              //1.Ask a user for a number.
              //2.Log that number to a text file.
              //3.Print the text file back to the user.

              Console.WriteLine("Select a number please?");
            string numberSelected = Console.ReadLine();
            File.ReadAllText("C:\\Users\\Owner\\Documents\\FilePath");
            using (StreamWriter File = new StreamWriter ("C:\\Users\\Owner\\Documents\\FilePath", true))
            {
                File.WriteLine(numberSelected);
            }
            Console.ReadLine();
            
        }
    }
}
