using System.ComponentModel.DataAnnotations;

namespace ContactListAPI_MVC.Models
{
    public class Person
    {
        [Required]
        [Key]
        public int id { get; set; }

        [Display(Name = "Vorname")]
        [StringLength(50)]
        public string firstName { get; set; }

        [Display(Name = "Nachname")]
        [StringLength(50)]
        public string lastName { get; set; }

        [Required]
        [Display(Name = "E-Mail Adresse")]
        [StringLength(50)]
        public string email { get; set; }
    }
}
