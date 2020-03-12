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
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      //Arrange
      string cityName = "Boston.";

      //Act
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;

      //Assert
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      //Arrange
      string cityName = "Boston.";
      Place newPlace = new Place(cityName);

      //Act
      string updatedCityName = "Paris";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;

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
      Place newPlace1 = new Place(cityName01);
      Place newPlace2 = new Place(cityName02);
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
      Place newPlace = new Place(cityName);

      //Act
      int result = newPlace.Id;
      // int result = 0;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      //Arrange
      string cityName01 = "Boston";
      string cityNamen02 = "New York";
      Place newPlace1 = new Place(cityName01);
      Place newPlace2 = new Place(cityName02);

      //Act
      Place result = Place.Find(1);

      //Assert
      Assert.AreEqual(newPlace1, result);
    }
  }
}