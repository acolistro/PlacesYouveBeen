using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Diary.Models;
using System;

namespace Diary.Tests
{
  [TestClass]
  public class PlaceTest : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test", 3, "test", "test", 1);
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      //Arrange
      string cityName = "Boston.";
      int duration = 5;
      string travelPartner = "Ted";
      string journalEntry = "abcd";
      int id = 1;


      //Act
      Place newPlace = new Place(cityName, duration, travelPartner, journalEntry, id);
      string result = newPlace.CityName;
      int resultD = newPlace.Duration;
      string resultTP = newPlace.TravelPartner;
      string resultJE = newPlace.JournalEntry;
      int resultID = newPlace.Id;

      //Assert
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      //Arrange
      string cityName = "Boston.";
      int duration = 5;
      string travelPartner = "Ted";
      string journalEntry = "abcd";
      int id = 1;
      Place newPlace = new Place(cityName, duration, travelPartner, journalEntry, id);

      //Act
      string updatedCityName = "Paris";
      int updatedDuration = 5;
      string updatedTravelPartner = "Ted";
      string updatedJournalEntry = "abcd";
      int updatedId = 1;
      newPlace.CityName = updatedCityName;
      newPlace.Duration = updatedDuration;
      newPlace.TravelPartner = updatedTravelPartner;
      newPlace.JournalEntry = updatedJournalEntry;
      newPlace.Id = updatedId;
      string result = newPlace.CityName;
      int resultD = newPlace.Duration;
      string resultTP = newPlace.TravelPartner;
      string resultJE = newPlace.JournalEntry;
      int resultID = newPlace.Id;

      //Assert
      Assert.AreEqual(updatedCityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      // Arrange
      List<Place> newList = new List<Place> { };

      // Act
      List<Place> result = Place.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      //Arrange
      string cityName01 = "Boston";
      string cityName02 = "Paris";
      int duration01 = 3;
      int duration02 = 4;
      string travelPartner01 = "Fred";
      string travelPartner02 = "Greg";
      string journalEntry01 = "asdf";
      string journalEntry02 = "lkjh";
      int id01 = 1;
      int id02 = 2;
      Place newPlace1 = new Place(cityName01, duration01, travelPartner01, journalEntry01, id01);
      Place newPlace2 = new Place(cityName02, duration02, travelPartner02, journalEntry02, id02);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      //Act
      List<Place> result = Place.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string cityName = "Boston";
      int duration = 3;
      string travelPartner = "Fred";
      string journalEntry = "asdf";
      int id = 1;
      Place newPlace = new Place(cityName, duration, travelPartner, journalEntry, id);

      //Act
      string resultCN = newPlace.CityName;
      int resultD = newPlace.Duration;
      string resultTP = newPlace.TravelPartner;
      string resultJE = newPlace.JournalEntry;
      int result = newPlace.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      //Arrange
      string cityName01 = "Boston";
      string cityName02 = "Paris";
      int duration01 = 3;
      int duration02 = 4;
      string travelPartner01 = "Fred";
      string travelPartner02 = "Greg";
      string journalEntry01 = "asdf";
      string journalEntry02 = "lkjh";
      int id01 = 1;
      int id02 = 2;
      Place newPlace1 = new Place(cityName01, duration01, travelPartner01, journalEntry01, id01);
      Place newPlace2 = new Place(cityName02, duration02, travelPartner02, journalEntry02, id02);

      //Act
      Place result = Place.Find(1);

      //Assert
      Assert.AreEqual(newPlace1, result);
    }
  }
}