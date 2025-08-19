using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
 

    class Book
    {

        public string Title { get; set; }
        public string Autor { get; set; }
        public void BookInfo()
        {
            Console.WriteLine($"Name Of book: {title}, Author: {autor}");
        }
    }
}
