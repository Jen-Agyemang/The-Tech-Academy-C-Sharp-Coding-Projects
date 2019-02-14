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
            var identity = new Identity();
            identity.Id = 39291;
            identity.Name = "Nana";
            Console.WriteLine("Hello {0}.", myIdentity);
            Console.WriteLine(identity.Id);
            Console.WriteLine(identity.Name);
            Console.ReadLine();
        }
    }
}
