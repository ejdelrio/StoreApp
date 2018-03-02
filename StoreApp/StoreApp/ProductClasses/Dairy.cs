using System;
namespace StoreApp.ProductClasses
{
  public class Dairy : Product
  {
    public string animalType;
    bool expired;
    bool freeRange;
    bool hormoneFree;
    bool grassFed;
    
    public Dairy(string animalType, string name, double price, double rawCoast, bool organic=false) :
    base(name, "Dairy", rawCoast, price, organic)
    {
      this.animalType = animalType;
    }
  }
}
