using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTask
{
    internal abstract class Shape
    {
        public int d1, d2;

        
        public Shape(int d1, int d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }
        public override string ToString()
        {
            return "01: "+d1+"\t 02: "+d2;
        }

       abstract public int area();
    }
}
