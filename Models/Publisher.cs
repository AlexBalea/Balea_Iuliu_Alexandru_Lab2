using System.ComponentModel.DataAnnotations;

namespace Balea_Iuliu_Alexandru_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Display(Name = "Publisher's Name")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
