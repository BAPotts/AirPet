using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AirPet.Models
{
  public class AirPetContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<MyUserInfo> MyUserInfo { get; set; }
    public AirPetContext(DbContextOptions options) : base(options) {}
  }
}