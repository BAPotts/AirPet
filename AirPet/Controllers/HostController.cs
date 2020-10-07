using Microsoft.AspNetCore.Mvc;
using AirPet.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AirPet.Controllers
{
  public class HostsController : Controller
  {
    private readonly AirPetContext _db;

    public HostsController(AirPetContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Host> model = _db.Hosts.Include(hosts => hosts.Location).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Host host)
    {
      _db.Hosts.Add(host);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Host thisHost = _db.Hosts.FirstOrDefault(hosts => hosts.HostId == id);
      return View(thisHost);
    }

    public ActionResult Edit(int id)
    {
      var thisHost = _db.Hosts.FirstOrDefault(hosts => hosts.HostId == id);
      ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "Name");
      return View(thisHost);
    }

    [HttpPost]
    public ActionResult Edit(Host host)
    {
      _db.Entry(host).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisHost = _db.Hosts.FirstOrDefault(hosts => hosts.HostId == id);
      return View(thisHost);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisHost = _db.Hosts.FirstOrDefault(hosts => hosts.HostId == id);
      _db.Hosts.Remove(thisHost);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}