using Microsoft.AspNetCore.Identity;

namespace AirPet.Models
{
  public class ApplicationUser : IdentityUser
  {
    public virtual Profile Profile {get; set; }
  }
}