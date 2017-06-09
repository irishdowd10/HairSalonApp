using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HairSalon
{
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

    public void Dispose()
    {

    }
  }
}
