using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.create an abstract class called person with two properties: string firstname and string lastname.

            //2. give it the method sayname().

            //3. create another class called employee and have it inherit from the person class.

            //4. implement the sayname() method inside of the employee class.

            //5. inside the main() method, instantiate an employee object with firstname "sample" and lastname "student". call the sayname() method on the object.

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
