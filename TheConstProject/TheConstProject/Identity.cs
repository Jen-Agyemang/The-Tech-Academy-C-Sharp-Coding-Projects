using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConstProject
{
    public class Identity
    {
        public string name;
        public int id;

        public Identity(string studentName, int Id)
        {

        }
        public Identity(string name) : this(name, 9454)
        {

            this.name = name;

        }
        public Identity(int id) : this("Nana", id)
        {
            this.id = id;
        }

        public Identity()
        {
        }
    }

}

