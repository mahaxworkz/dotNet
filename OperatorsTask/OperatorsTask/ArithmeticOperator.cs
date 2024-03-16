using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTask
{
    internal class ArithmeticOperator
    {
       public void  arithmeticfunction(int num1,int num2)
        {
            Console.WriteLine("subtraction"+(num1-num2));
            Console.WriteLine("Addition" + (num1 + num2));
            Console.WriteLine("multiplication" + (num1 *num2));
            Console.WriteLine("divition" + (num1 /num2));
            Console.WriteLine("reminder" + (num1 % num2));
        }
    }
}
