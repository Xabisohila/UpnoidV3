using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpnoidV3.Models;

namespace UpnoidV3.ViewModels
{
    public class RentalViewModel
    {
        public List<Movie> movies { get; set; }
        public List<Customer> customers { get; set; }
    }
}
