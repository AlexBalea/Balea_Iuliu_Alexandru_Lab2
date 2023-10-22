using System.ComponentModel.DataAnnotations;

namespace Balea_Iuliu_Alexandru_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }


        [Display(Name = "Author's First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Author's Last Name")]
        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
