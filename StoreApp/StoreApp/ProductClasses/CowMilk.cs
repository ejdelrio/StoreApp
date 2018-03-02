using System;
namespace StoreApp.ProductClasses
{
  public class CowMilk : Dairy
  {
    public CowMilk(double price, double rawCost, bool organic=false) : 
    base("Cow", "Milk", price, rawCost)
    {
    }
  }
}
