using Microsoft.AspNetCore.Mvc;
using Diary.Models;
using System.Collections.Generic;
using System;

namespace Diary.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places/show")]
    public ActionResult Create(string cityName, int duration, string travelPartner, string journalEntry, int id)
    {
      Place myPlace = new Place(cityName, duration, travelPartner, journalEntry, id);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

  }
}