using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Math
    {
        public void Operation(int a, int b)
        {
            //a = 2;
            //b = 5;
            Console.WriteLine("The names of the math operations are: {a} and {b}" );
            Console.WriteLine("a plus b equals " + (a + b));
            Console.WriteLine("Number: {b} is " + b);
            Console.ReadLine();
        }

    }
}
