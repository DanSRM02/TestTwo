using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class TestTwoContext : DbContext
    {
        public TestTwoContext()
        {
        }
        public TestTwoContext(DbContextOptions<TestTwoContext> options)
            : base(options)
        {
        }     

        public DbSet<Volunteer> Volunteers { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;

        public DbSet<VolunteerAvailability> VolunteerAvailabilities { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VolunteerAvailability>()
                .HasOne(va => va.Volunteer)
                .WithMany(v => v.Availabilities)
                .HasForeignKey(va => va.VolunteerId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
