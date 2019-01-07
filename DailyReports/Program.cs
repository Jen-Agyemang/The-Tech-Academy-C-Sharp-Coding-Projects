using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReports
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
           

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int numberPage = Convert.ToInt32(pageNumber);
            Console.ReadLine();
            
       

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\" ");
            string needHelp = Console.ReadLine();

  
            
            

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string positiveExperiences = Console.ReadLine();
            

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studiedHours = Convert.ToInt32(hoursStudied);
            
               
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
