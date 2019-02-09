using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEnumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FirstEnumProject theDays = new FirstEnumProject();
                Console.WriteLine("Please select the current day of the week?");
                string daySelected = Console.ReadLine();
                 var day = (Days)Enum.Parse(typeof(Days), daySelected);
                Console.WriteLine("Today is {0}. ", (Days)Enum.Parse(typeof(Days), daySelected));
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(" Please enter an actual day of the week. Thank you.");
                Console.ReadLine();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}


       
    

