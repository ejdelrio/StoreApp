using System;
namespace StoreApp
{
  public class Address
  {
    public string streetAddress;
    public string secondAddressLine;
    public string city;
    public string state;
    public int zip;

    public Address(string streetAddress, string city, string state, int zip, string secondAddressLine=null)
    {
      this.streetAddress = streetAddress;
      this.state = state;
      this.zip = zip;
      this.city = city;
      if (secondAddressLine != null) this.secondAddressLine = secondAddressLine;
    }
  }
}
