using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math calc = new Math();
            //int myValue = 5;
            //int secondValue = 2;
            //calc.Operation(myValue, secondValue);
            //Console.WriteLine(myValue + secondValue);
            //Console.ReadLine();

            Math calc = new Math();
            calc.Operation(2, 5);
        }
    }
}
