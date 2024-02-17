using System.ComponentModel.DataAnnotations;

namespace Mission06_Finch.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int FormID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public int Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        [Range(0,25)]
        public string? Notes { get; set; }




    }
}
