using System.Collections.Generic;
using System.Drawing;

namespace Diary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    // public byte[] Image { get; set; }
    public int Duration { get; set; }
    public string TravelPartner { get; set; }
    public string JournalEntry { get; set; }
    public int Id { get; set; }
    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName, int duration, string travelPartner, string journalEntry, int id)
    {
      CityName = cityName;
      // Image = image;
      Duration = duration;
      TravelPartner = travelPartner;
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}