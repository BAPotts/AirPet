using Microsoft.AspNetCore.Identity;

namespace AirPet.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string Bio { get; set; }
  }
}