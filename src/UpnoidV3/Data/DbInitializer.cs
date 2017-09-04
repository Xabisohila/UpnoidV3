using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpnoidV3.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace UpnoidV3.Data
{
    public class DbInitializer
    {
        public static void Initialize(UpnoidContext context)
        {
            //context.Database.EnsureCreated();
            //look for any genres

            if (context.Genres.Any())
            {
                return; //DB has been added
            }

            var genres = new Genre[]
            {
                new Genre {Name = "Comedy"},
                new Genre {Name = "Thriller"},
                new Genre {Name = "Action"},
                new Genre {Name = "Drama"},
                new Genre {Name = "Horror"},
                new Genre {Name = "Romance"}
            };

            foreach(Genre i in genres)
            {
                context.Genres.Add(i);
            }
            context.SaveChanges();

            if (context.Genres.Any())
            {
                return; //DB has been added
            }
            // look for any movies
            var movies = new Movie[]
            {
              //  new Movie {Name = "Fate and Furius", GenreId='Action', NumberInStock=15, Price=18, ReleaseDate=DateTime.Parse("2016-03-11"), DateAdded=DateTime.Now},
                new Movie {Name = "Thriller"},
                new Movie {Name = "Action"},
                new Movie {Name = "Drama"},
                new Movie {Name = "Horror"},
                new Movie {Name = "Romance"}
            };

            foreach (Movie i in movies)
            {
                context.Movies.Add(i);
            }
            context.SaveChanges();
        }
    }
}
