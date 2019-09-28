using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCBookstore.Models
{
    public enum Category
    {
        Children, Comics, Drama, Fantasy, Games, Health, Journal, Poetry, SciFi
    }

    public enum Publisher
    {
        Canadian, International
    }

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
        public DateTime? PublishDate { get; set; }
        public Publisher? Publisher { get; set; }
        public Category? Category { get; set; }
        public Int16? Pages { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public Decimal? Price { get; set; }
    }
}