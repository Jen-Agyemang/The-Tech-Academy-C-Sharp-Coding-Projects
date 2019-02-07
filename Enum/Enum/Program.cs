using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TheDaysOfTheWeek theDays = new TheDaysOfTheWeek();
                theDays.TheDay = theDays.TheDay;
                Console.WriteLine("Please select the current day of the week?");
                string daySelected = Console.ReadLine();
                var week = System.Enum.Parse(typeof(Days), daySelected);
                Console.WriteLine(System.Enum.Parse(typeof(Days), daySelected));
                //Console.WriteLine("Today is : ", System.Enum.Parse(typeof(Days), daySelected));
                Console.WriteLine("Today is {0}. ", System.Enum.Parse(typeof(Days), daySelected));
              //  Console.WriteLine(System.Enum.GetName(typeof(Days), theDays));

            }
            catch (FormatException e)
            {
                Console.WriteLine("Unable to convert to a date. Please enter an actual day of the week. Thank you.");
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
           // DateTime d = DateTime.Now;
        }
    }
}
