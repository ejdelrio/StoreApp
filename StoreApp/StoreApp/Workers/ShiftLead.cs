using System;
namespace StoreApp.Workers
{
  public class ShiftLead : Cashier
  {
    public ShiftLead(string first, string last, int age, Address homeAddress, double payRate=15.00, string position="Shift Lead") :
    base(first, last, age, homeAddress, payRate, position)
    {
    }
  }
}
