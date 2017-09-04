using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpnoidV3.Dtos;
using UpnoidV3.Models;
using Microsoft.EntityFrameworkCore;

namespace UpnoidV3.Controllers
{
    public class RentalsController : Controller
    {
        private UpnoidContext _context;
        public RentalsController(UpnoidContext context)
        {
            _context = context;
        }
        /*
                [HttpPost]
                public async Task<IActionResult>CreateNewRental(NewRentalDto newRental)
                {
                    var customer = await _context.Customers.Single
                        (c => c.ID == newRental.Customers);

                    var movie = await _context.Customers.SingleAsync(m => m.ID == newRental.Customers);

                    var movies = await _context.Movies.Where
                        (m => newRental.Movies.Contains(m.Id)).ToList();

                    foreach (var movie in movies)
                    {
                        if (movie)
                        {

                        }
                    }

                }

            */
        public IActionResult New()
        {
            return View();
        }
  /*      
        [HttpPost]
        public IActionResult Index (NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.ID == newRental.Customers.ID);

            var movies = _context.Movies.Single(m => m.Id == newRental.Movies.ToList());

            var movies = _context.Movies.Where(m => id.ID.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if(mo in ip)
            }

*/
        }
    }

