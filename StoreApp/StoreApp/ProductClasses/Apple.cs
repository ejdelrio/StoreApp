using System;
namespace StoreApp.ProductClasses
{
  public class Apple : Produce
  {
    public Apple(string company, string origin, double price, double rawCost, bool organic=false) :
    base(origin, company, "Apple", price, rawCost, organic)
    {
    }
  }
}
