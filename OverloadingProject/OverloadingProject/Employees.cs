using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingProject
{
    public class Employees<T>
    {
        public List<T> Things { get; set; }

        //public string Id { get; set; }
        //public string Firstname { get; set; }
        //public string Lastname { get; set; }

        //public static bool operator == (Employees employee1, Employees employee2)
        //{
        //    return employee1.Id == employee2.Id;
        //}
        //public static bool operator !=(Employees employee1, Employees employee2)
        //{
        //    return employee1.Id != employee2.Id;

        //}


    }
}
