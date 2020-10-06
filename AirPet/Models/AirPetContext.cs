using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AirPet.Models
{
  public class AirPetContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Location> Locations {get; set; }
    public DbSet<Host> Hosts {get; set;}
    public DbSet<Profile> Profile { get; set; }
    public AirPetContext(DbContextOptions options) : base(options) {}
  }
}