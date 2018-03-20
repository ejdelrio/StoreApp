using System;
namespace StoreApp
{
  public class Person : Human
  {
    public string firstName;
    public string lastName;
    int age;
    DateTime DOB;
    Address homeAddress;

    public Person(string first, string last, int age)
    {
      firstName = first;
      lastName = last;
      this.age = age;
    }

    public void addAddress(Address addr) {
      homeAddress = addr;
    }
  }
}
