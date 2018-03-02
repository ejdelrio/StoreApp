using System;
using StoreApp.ProductClasses;
using System.Collections.Generic;

namespace StoreApp
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Banana DoleBanana = new Banana("Columbia", "Dole", 1.20, 0.20);
      Banana DoleBananaOrganic = new Banana("Columbia", "Dole", 1.50, 0.30, true);
      CowMilk gallonOMilk = new CowMilk(4.90, 1.50);



    }
  }
}
