using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTask
{
    internal class LogicalOperator
    {
        public void logicalfunction(int n,int m)
        {
            if(n != 0 || m == 0)
            {
                Console.WriteLine("Either n or m is non zero value");
            } else if(n!=0 && m != 0)
            {
                Console.WriteLine("both n and m is non zero value ");
            }
        }
    }
}
