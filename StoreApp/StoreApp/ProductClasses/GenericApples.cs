using System;
namespace StoreApp.ProductClasses
{
  public class GenericApples : Apple
  {
    long serialNumber;
    public GenericApples(double price, double rawCost, long serialNumber, bool organic=false) :
    base("Washington", "Generic Apples Co.", price, rawCost, organic)
    {
      this.serialNumber = serialNumber;
    }
  }
}
