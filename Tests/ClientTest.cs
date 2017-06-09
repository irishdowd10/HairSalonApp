using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HairSalon
{
  [Collection("HairSalon")]
  public class ClientTest : IDisposable
  {
    Stylist parentStylist;

    public ClientTest()
    {
        DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=hair_salon_test;Integrated Security=SSPI;";

        parentStylist = new Stylist("Judy Johnson", 1);
        parentStylist.Save();
    }

    public void Dispose()
    {
      Stylist.DeleteAll();
      Client.DeleteAll();
    }

    [Fact]
    public void CreateAndReturnClient()
    {
      Client client = new Client("Frank Jones", parentStylist.GetId(), 1);

      client.Save();

      Client savedClient = Client.GetAll()[0];

      Assert.Equal(savedClient, client);
    }

    [Fact]
    public void DeleteClient()
    {
      Client client = new Client("Frank Jones", parentStylist.GetId(), 1);

      client.Save();
      client.Delete();

      List<Client> clientList = Client.GetAll();

      Assert.Equal(clientList.Count, 0);
    }

    [Fact]
    public void UpdateClient()
    {
      Client client = new Client("Frank Jones", parentStylist.GetId(), 1);
      client.Save();

      client.Update("Jim Jones");
      Client savedClient = Client.GetAll()[0];

      Assert.Equal(client.GetName(), "Jim Jones");
    }

  }
}
