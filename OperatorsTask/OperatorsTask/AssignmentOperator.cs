using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTask
{
    internal class AssignmentOperator
    {
        public  void assignFunction(int n1,int n2)
        {
            

            Console.WriteLine("assignment num = " + n1);
            n1 += n2;
            Console.WriteLine(" addition assignment : num = " + n1);
            n1 -= n2;
            Console.WriteLine("subtraction assignment : num = " + n1 );
            n1 *= n2;
            Console.WriteLine(" multiplication assignment : num = " + n1);
            n2 /= n1;
            Console.WriteLine(" division assignment : num = " + n1);
           

        }
    }
}
