using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Book
    {
        public int BookId {  get; set; }

        public string Title { get; set; }   

        public string Author { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }
    }
}
