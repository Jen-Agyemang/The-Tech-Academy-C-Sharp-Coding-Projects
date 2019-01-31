using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodProject
{
    public class Math
    {
        public void MathProblem( out int a)
        {
            a = 4;
            Console.WriteLine("a divided by two equals: " + a / 2 + ".");
            Console.WriteLine("Please enter any number of your choice?");
            int numberSelected = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number selected divided by 2 equals: " + numberSelected / 2);

        }
        public void Mathproblem2(out int b)
        {
            b = 2;
        }
        static class Mathemathics 
        {
            public static void MathProblem3(out int c)
            {
                c = 2;
            }
        }
    }
}
