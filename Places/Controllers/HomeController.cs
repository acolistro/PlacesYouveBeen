using Microsoft.AspNetCore.Mvc;
using Diary.Models;
using System.Collections.Generic;

namespace DIary.Controllers
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
    public ActionResult Create(string description)
    {
      Place myPlace = new Place(description);
      return RedirectToAction("Index");
    }

  }
}