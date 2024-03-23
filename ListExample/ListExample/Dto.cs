using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Dto
    {
       public  String author { set; get; }
        public String book { set; get; }
        public String price { set; get; }

        public Dto(string author, string book, string price)
        {
            this.author = author;
            this.book = book;
            this.price = price;
        }

        public Dto()
        {


        }
         
            
    }
}
