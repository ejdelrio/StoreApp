using System;
namespace StoreApp
{
  public class Produce : Product
  {
    public string origin;
    public string company;
    bool isRipe;
    bool isRotten;


    public Produce(string origin, string company, string name, double price, double rawCost, bool organic=false) :
    base(name, "Produce", rawCost, price, organic)
    {
      this.origin = origin;
      this.company = company;
    }
  }
}
