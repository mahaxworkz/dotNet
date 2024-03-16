using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{
     class Employee
    {
        public String name;
        public int id;
        public int salary;
        public String gender;
        public bool experience;

        public Employee()
        {
        }

        public Employee(string name, int id, int salary, string gender, bool experience)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
            this.gender = gender;
            this.experience = experience;
        }
        public virtual void SetValue()
        {
            Console.Write("Enter name :");
            name = Console.ReadLine();
            Console.Write("Enter id :");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter salary :");
            salary = int.Parse(Console.ReadLine());
            Console.Write("Enter gender :");
            gender = Console.ReadLine();
            Console.Write("Enter experience :");
            experience=bool.Parse(Console.ReadLine());

        }
        public virtual void GetValue()
        {
            Console.WriteLine($"name : {name}");
            
            Console.WriteLine($"  id :{id}");
            
            Console.WriteLine($"salary : {salary}");
            
            Console.WriteLine($" gender :{gender}");
            
            Console.WriteLine($" experience :{experience}");
            

        }

        public override String ToString()
        {
            return $"hi ! I am {name}.my id is {id}. " +
                $"I am {gender} employee with {salary} salary.";
        }
    }
}
