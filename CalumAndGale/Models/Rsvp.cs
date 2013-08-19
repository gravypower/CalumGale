using System.ComponentModel.DataAnnotations;

namespace CalumAndGale.Models
{
    public class Rsvp
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Key]
        public string Email { get; set; }
    }
}