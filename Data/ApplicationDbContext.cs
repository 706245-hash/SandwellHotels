using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SandwellHotels.Models;

namespace SandwellHotels.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SandwellHotels.Models.HotelRoom> HotelRoom { get; set; } = default!;
        public DbSet<SandwellHotels.Models.Booking> Booking { get; set; } = default!;
    }
}
