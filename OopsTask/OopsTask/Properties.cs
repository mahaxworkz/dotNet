using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{
    internal class Properties
    {
        public int id { set; get; } 
        public String name { set; get; }    
        public int age { set; get; }

        public Properties(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
}
