using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    
    public class Student
    {
        public int rollNo;
        public String name;
        public String fathername;
        public int age;
        public long phoneNo;
        public Address address;

        public Student(int rollNo, string name, string fathername, int age, long phoneNo, Address address)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.fathername = fathername;
            this.age = age;
            this.phoneNo = phoneNo;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine( $"hii !! ,I'm {name} ,I'm living in {address.city},my father name is {fathername}");
        }

    }
}
