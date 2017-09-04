using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UpnoidV3.Models;

namespace UpnoidV3.ViewModels
{
        public class MovieViewModel
        {
            public int? Id { get; set; }

            [Required]
            [StringLength(255)]
            public string Name { get; set; }

            [Display(Name = "Genre")]
            [Required]
            public string Genre { get; set; }

            [Display(Name = "Release Date")]
            [DataType(DataType.Date)]
            [Required]
            public DateTime? ReleaseDate { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Date Added")]
            public DateTime DateAdded { get; set; }

            [Required]
            [Range(1, 100)]
            [DataType(DataType.Currency)]
            public double Price { get; set; }

            [Display(Name = "Number in Stock")]
            [Range(1, 20)]
            [Required]
            public byte? NumberInStock { get; set; }

            public List<Genre> GenreList { get; set;}


/*
            public string Title
            {
                get
                {
                    return Id != 0 ? "Edit Movie" : "New Movie";
                }
            }

            public MovieFormViewModel()
            {
                Id = 0;
            }

            public MovieFormViewModel(Movie movie)
            {
                Id = movie.Id;
                Name = movie.Name;
                ReleaseDate = movie.ReleaseDate;
                NumberInStock = movie.NumberInStock;
            }
*/
        }
    }
