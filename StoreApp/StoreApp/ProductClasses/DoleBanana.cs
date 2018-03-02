using System;
namespace StoreApp.ProductClasses
{
  public class DoleBanana : Banana
  {
    long serialNumber;

    public DoleBanana(double price, double rawCost, long serialNumber) :
    base("Columbia", "Dole", price, rawCost, false)
    {
      this.serialNumber = serialNumber;
    }
  }
}
