using AvailabilityUI.Models;
using Microsoft.EntityFrameworkCore;

namespace AvailabilityUI.Data
{
    public class AvailabilityUIContext  : DbContext
    {
        public AvailabilityUIContext(DbContextOptions<AvailabilityUIContext> options) : base(options)
        {
        }

        public DbSet<Availability> Availabilities { get; set; }
    }
}