using Microsoft.AspNetCore.Mvc;
using AirPet.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace AirPet.Controllers
{
  public class ProfileController : Controller
  {
    private readonly AirPetContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
  
    public ProfileController(UserManager<ApplicationUser> userManager, AirPetContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Profile profile)
    {
      _db.Profile.Add(profile);
      // if (RecipeId != 0 )
      // {
      //   _db.RecipeTag.Add(new RecipeTag() { RecipeId = RecipeId, TagId = tag.TagId });
      // }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}