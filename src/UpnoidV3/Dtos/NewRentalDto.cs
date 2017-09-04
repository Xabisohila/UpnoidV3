using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpnoidV3.Models;

namespace UpnoidV3.Dtos
{
    public class NewRentalDto
    {
        public Customer Customers { get; set; }
        public List<Movie> Movies { get; set; }
        
    }
}
