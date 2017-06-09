using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HairSalon
{
  [Collection("HairSalon")]
  public class StylistTest : IDisposable
  {
    public StylistTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void CreatesAndReturnsStylist()
    {
      Stylist stylist = new Stylist("Jody Johnson", 1);

      stylist.Save();

      Stylist savedStylist = Stylist.GetAll()[0];

      int result = savedStylist.GetId();
      int testId = stylist.GetId();

      Assert.Equal(result, testId);
    }

    [Fact]
    public void ReturnAllStylists()
    {
      Stylist stylist = new Stylist("Jody Johnson", 1);
      Stylist stylist2 = new Stylist("Judy Johnson", 2);

      stylist.Save();
      stylist2.Save();

      List<Stylist> stylistList = Stylist.GetAll();
      Assert.Equal(new List<Stylist> { stylist, stylist2 }, stylistList);
    }

    [Fact]
    public void DeleteStylistNoClients()
    {
      Stylist stylist = new Stylist("Jody Johnson", 1);

      stylist.Save();

      stylist.Delete();

      int length = Stylist.GetAll().Count;

      Assert.Equal(length, 0);
    }

    // [Fact]
    // public void DeleteStylistWithClients()
    // {
    //   Stylist stylist = new Stylist("Jody Johnson", 1);
    //   Client client = new Client("Frank Beans", 1, 1);
    //
    //   stylist.Save();
    //   client.Save();
    //
    //   stylist.Delete();
    //
    //   int clientLength = Client.GetAll().Count;
    //   Assert.Equal(clientLength, 0);
    // }

    [Fact]
    public void UpdateStylist()
    {
      Stylist stylist = new Stylist("John Jones", 1);
      stylist.Save();

      stylist.Update("Jim Jones");

      Stylist savedStylist = Stylist.GetAll()[0];

      Assert.Equal(savedStylist.GetName(), "Jim Jones");
    }

    public void Dispose()
    {
      Stylist.DeleteAll();
    }
  }
}
