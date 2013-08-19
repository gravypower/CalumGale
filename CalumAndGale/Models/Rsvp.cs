using System.ComponentModel.DataAnnotations;

namespace CalumGayleWeb.Models
{
    public class Rsvp
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Key]
        public string Email { get; set; }

        [Required]
        public string Names { get; set; }

        public bool Australia { get; set; }

        public bool Ireland { get; set; }

        public bool NotGoing { get; set; }
    }
}