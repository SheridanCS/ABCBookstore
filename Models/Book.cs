using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ABCBookstore.Models
{
    public class Book
    {
        public String BookId { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Please enter the author name(s)")]
        public String Authors { get; set; }

        [Required(ErrorMessage = "Please enter the ISBN")]
        public String ISBN { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        public DateTime PublishDate { get; set; }
        public String Publisher { get; set; }
        public Category Category { get; set; }
        public Int16 Pages { get; set; }
        public Decimal Price { get; set; }
    }
}