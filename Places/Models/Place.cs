using System.Collections.Generic;
using System.Drawing.Image;

namespace Diary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public byte[] Image { get; set; }
    public int Duration { get; set; }
    public string TravelPartner { get; set; }
    public string JournalEntry { get; set; }
    private static List<Place> _instances = new List<Place> {};

    public Item (string cityName, byte[] image, int duration, string travelPartner, string journalEntry)
    {
      CityName = cityName;
      Image = image;
      Duration = duration;
      TravelPartner = travelPartner;
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}