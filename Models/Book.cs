using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Balea_Iuliu_Alexandru_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Display(Name = "Author Name")]
        public int? AuthorID { get; set; }

        [Display(Name = "Author Name")]
        public Author? Author { get; set; } //navigation property

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        [Display(Name = "Publisher Name")]
        public int? PublisherID { get; set; }

        [Display(Name = "Publisher Name")]
        public Publisher? Publisher { get; set; } //navigation property

    }
}
