using System.ComponentModel.DataAnnotation;

namespace CommandAPI.Models{

    public class 
    {
        [Key]
        [Required]
        public int Id{get; set;}

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public str Platform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}