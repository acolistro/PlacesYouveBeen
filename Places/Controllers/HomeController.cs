using Microsoft.AspNetCore.Mvc;
using Diary.Models;
using System.Collections.Generic;

namespace Diary.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, int duration, string travelPartner, string journalEntry, int id)
    {
      Place myPlace = new Place(cityName, duration, travelPartner, journalEntry, id);
      return RedirectToAction("Index");
    }

  }
}