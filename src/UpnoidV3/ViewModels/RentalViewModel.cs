using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UpnoidV3.Models;

namespace UpnoidV3.ViewModels
{
    public class RentalViewModel
    {
        
        [Required(ErrorMessage = "You cannot submit a form without a movie name")]
        public List<Movie> movies { get; set; }

        [Required(ErrorMessage = "You cannot submit a form without a customer name")]
        public List<Customer> customers { get; set; }
    }
}
