using Microsoft.AspNetCore.Mvc;

namespace AirPet.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}