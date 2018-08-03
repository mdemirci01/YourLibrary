using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YourLibrary.Models
{
    public class Author:BaseEntity
    {
        [Display(Name = "Yazar Adı")]
        [StringLength(200)]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
