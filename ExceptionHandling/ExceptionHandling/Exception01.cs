using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exception01 : Exception
    {
        String msg;
         public Exception01(String msg) : base(msg) { 
           this. msg=msg;
        
        }
        public override string ToString()
        {
            return msg;
        }


 
    }
}
