using Microsoft.AspNetCore.Identity;

namespace AirPet.Models
{
  public class ApplicationUser : IdentityUser
  {
    public virtual MyUserInfo MyUserInfo { get; set; }
  }

  public class MyUserInfo
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Location  { get; set; }
    public string Pets { get; set; }
    public string Bio { get; set; }
  }
}