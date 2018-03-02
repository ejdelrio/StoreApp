using System;
using System.Collections.Generic;
namespace StoreApp.ProductClasses
{
  public class ShoppingCart
  {
    List<Product> contents = new List<Product> { };

    public void addToCart(Product item, int qty=1) 
    {
      for (int i = 0; i < qty; i++)
      {
        contents.Add(item);
      }

    }

    public void removeFromCart(Product item, int qty=1)
    {
      List<Product> filteredCart = new List<Product> { };

      int removedSoFar = 0;
      for (int i = 0; i < contents.Count; i++) {
        if (removedSoFar == qty) {
          filteredCart.Add(contents[i]);
          continue;
        }
        Product itemAtIndex = contents[i];
        if (itemAtIndex.serialNumber != item.serialNumber){
          filteredCart.Add(itemAtIndex);
          removedSoFar += 1;
        }
      }
      contents = filteredCart;
    }

    public void removeallOfType(Product item)

    {
      List<Product> filteredCart = new List<Product> { };
      for (var i = 0; i < contents.Count; i++) {
        Product itemAtIndex = contents[i];
        if (itemAtIndex.serialNumber != item.serialNumber) filteredCart.Add(itemAtIndex);
      }
      contents = filteredCart;
    }

    public void emptyCart() {
      contents.Clear();
    }
  }
}
