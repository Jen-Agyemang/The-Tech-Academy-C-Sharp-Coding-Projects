using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConstProject
{
    public class Identity
    {
        public int Id;
        public string Name;

        public Identity()
        {

        }

        public Identity(int id)
        {
            this.Id = id;
        }
        public Identity(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
