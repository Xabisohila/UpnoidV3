using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UpnoidV3.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public String Genres {get;set;}
        [Required]
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}
