using System;
namespace StoreApp.ProductClasses
{
  public class Banana : Produce
  {

    public Banana(string origin, string company, double price, double rawCost, bool organic=false) :
    base(origin, company, "Banana", price, rawCost, organic)
    {
    }
  }
}
