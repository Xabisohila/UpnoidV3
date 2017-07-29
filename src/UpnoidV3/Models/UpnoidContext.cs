using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UpnoidV3.Models
{
    public class UpnoidContext: IdentityDbContext<ApplicationUser>
    {
        public UpnoidContext(DbContextOptions<UpnoidContext> options)
            : base(options)
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
    }
}
