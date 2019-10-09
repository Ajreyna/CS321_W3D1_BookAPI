using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W3D1_BookAPI.Models
{
    public class Book
    {
       public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Exceeded Maximum title length")]
      public string Title { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Exceeded maxixmum author name length")]
        public string Author { get; set; }
        public string Category { get; set; }
        
    }
}
