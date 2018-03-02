using System;
namespace StoreApp.Workers
{
  public class Supervisor : ShiftLead
  {
    public Supervisor(string first, string last, int age, Address homeAddress, double payRate=18.00, string position="Supervisor") :
    base(first, last, age, homeAddress, payRate, position)
    {
    }
  }
}
