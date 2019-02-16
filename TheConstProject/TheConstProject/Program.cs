using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a const variable
            //2.Create a variable using the keyword "var".
            //3.Chain two constructors together.

            const string myIdentity = "Jen Agyemang";
            Console.WriteLine("Hello, {0}.", myIdentity);
            var identity = new Identity();
            identity.id = 98898;
            identity.name = "Jennifer";
            Console.WriteLine(identity.id);
            Console.WriteLine(identity.name);
            Console.ReadLine();
        }
    }
}
