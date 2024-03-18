using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal class Staffs : MyInterface
    {
        String name;
        int id;
        int age;

        public Staffs(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        void MyInterface.AddData()
        {
            Console.WriteLine("data added");
        }

        void MyInterface.ReadData()
        {
            
            Console.WriteLine(" staff name: "+name);
            Console.WriteLine("staff id: " + id);
            Console.WriteLine("staff age: " + age);


        }
    }
}
