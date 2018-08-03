using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourLibrary.Models
{
    public class Book:BaseEntity
    {
        [Display(Name = "Kitap Adı")]
        [StringLength(200)]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Yazar")]
        [Required]
        public string AuthorId { get; set; } 
        [Display(Name = "Yazar")]
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
