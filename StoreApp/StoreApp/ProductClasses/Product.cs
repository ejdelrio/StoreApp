using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
namespace StoreApp
{
  public class Product
  {
    public string name;
    public string department;
    public double price;
    public bool organic;
    double rawCost;
    public long serialNumber;
    int quantityInStock;

    public static Dictionary<long, Product> productCatalog = new Dictionary<long, Product> { };


    public Product(string name, string department, double rawCost, double price, bool organic=false) 
    {
      this.name = name;
      this.rawCost = rawCost;
      this.department = department;
      this.price = price;
      this.organic = organic;
      serialNumber = GenerateUniqueSerial();
      productCatalog.Add(serialNumber, this);
    }

    public Product AddToCart() {
      return this;
    }

    static long GenerateUniqueSerial() {
      long randomSerial; 
      Random rnd = new Random();

      byte[] buf = new byte[8];
      rnd.NextBytes(buf);
      long longRand = BitConverter.ToInt64(buf, 0);

      long result = (Math.Abs(longRand % (2000000000000000 - 1000000000000000)) + 1000000000000000);
      long random_seed = (long)rnd.Next(1000, 5000);
      random_seed = random_seed * result + rnd.Next(1000, 5000);
      randomSerial = (long)(random_seed / 655) % 10000000000000001;

      while(productCatalog.ContainsKey(randomSerial)) {
        Console.WriteLine("__RANDOM_SERIAL__: " + randomSerial);
        random_seed = (long)rnd.Next(1000, 5000);
        random_seed = random_seed * result + rnd.Next(1000, 5000);
        randomSerial = (long)(random_seed / 655) % 10000000000000001;
      }

      return randomSerial;
    }
  }
}
