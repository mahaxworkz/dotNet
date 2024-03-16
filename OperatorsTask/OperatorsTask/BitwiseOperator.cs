using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTask
{
    internal class BitwiseOperator
    {
        public void bitwiseOperator(int x,int y)
        {
            int bitwiseAnd = x & y;
            int bitwiseOR = x | y;
            int bitwiseXOR = x ^ y;
            int bitwiseNot = ~x;
            int rightShift =x >> y;
            int leftShift = x << y;
            Console.WriteLine("bitwise AND" +bitwiseAnd);
            Console.WriteLine("bitwise OR" + bitwiseOR);
            Console.WriteLine("bitwise Not"+bitwiseNot);
            Console.WriteLine("bitwise XOR"+bitwiseXOR);
            Console.WriteLine("rightShift" + rightShift);
            Console.WriteLine("leftShift" + leftShift);


        }

    }
}
