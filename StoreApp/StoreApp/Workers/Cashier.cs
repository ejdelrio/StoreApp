using System;
namespace StoreApp.Workers
{
  public class Cashier : Employee
  {
    public Cashier(string first, string last, int age, Address homeAddress, double payRate = 12.75, string position="Cashier") :
    base(payRate, position, first, last, age, homeAddress)
    {
    }

    class Transaction
    {
      double total;

      public void RingUpItem(Product Item)
      {
        bool isInInventory = Product.productCatalog.ContainsKey(Item.serialNumber);
        if (!isInInventory) throw new ArgumentException("Item is not catalogged");

        total += Item.price;
      }
    }
  }
}
