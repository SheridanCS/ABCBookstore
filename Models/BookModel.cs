using System;
using System.Collections;

namespace ABCBookstore.Models
{
    public class BookModel
    {
        public String Title { get; set; }
        public ArrayList Authors { get; set; }
        public String ISBN { get; set; }
        public DateTime PublishDate { get; set; }
        public String Publisher { get; set; }
        public Category Category { get; set; }
        public Int16 Pages { get; set; }
        public Decimal Price { get; set; }
    }
}