using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Finch.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        //public Category Category { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter a movie title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter a year.")]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be after 1888.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "Sorry, you need specify if it is edited.")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Range(0,25)]
        [Required(ErrorMessage = "Sorry, you need to specify if it is copied to Plex")]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }




    }
}
