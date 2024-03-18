using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal class Student : MyInterface
    {
        String name;
        int id, age;

        public Student(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        void MyInterface.AddData()
        {
            Console.WriteLine("data added successfully");
        
        }

        void MyInterface.ReadData()
        {
            Console.WriteLine("student name: " + name);
            Console.WriteLine("student id: " + id);
            Console.WriteLine("student age: " + age);

        }
    }
}
