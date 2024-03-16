using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{
    internal class ITEmployee : Employee
    {
        public String company;
        public int noOfEmployees;

        public override void SetValue()
        {
            base.SetValue();
            Console.Write("Enter company name :");
            company = Console.ReadLine();
            Console.Write("Enter No of Employee :");
            noOfEmployees = int.Parse(Console.ReadLine());

        }
        public override void GetValue()
        {
            base.GetValue();
            Console.WriteLine($"Company name : {company}");

            Console.WriteLine($"  NoOf employees :{noOfEmployees}");
        }
        public override String ToString()
        {
            return base.ToString() + $"my company name is {company},it has {noOfEmployees} employees";
        }
    }
}
