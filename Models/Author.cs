using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Stefanut_Catalin_Adrian_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name = "Author Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Author Name")]
        public string FullName { get { return FirstName + " " + LastName; } }

        public ICollection<Book>? Books { get; set; }
    }
}
