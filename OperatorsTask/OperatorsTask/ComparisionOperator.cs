using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTask
{
    internal class ComparisionOperator
    {
        public void compareValue(int value1,int value2)
        {
            if (value1 < value2)
            {
                Console.WriteLine("value2 is greater than value1");
            }else if(value1 > value2) {
                Console.WriteLine("value1 is greater than value2");
            }else if(value1== value2)
            {
                Console.WriteLine("value2 is equal to value1");
            }
            else
            {
                Console.WriteLine("value2 is not equal to value1");  
            }
        }
    }
}
