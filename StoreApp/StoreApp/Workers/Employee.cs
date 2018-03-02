using System;
using System.Collections.Generic;
namespace StoreApp
{
  public class Employee : Person
  {

    public string position;
    double payRatePerHour;
    long employeeId;

    static Dictionary<long, Employee> employeeRoster = new Dictionary<long, Employee> { };

    public Employee(
      double payRate,
      string position,
      string first,
      string last, 
      int age, 
      Address homeAddress
    ) : 
    base(first, last, age)
    {
      payRatePerHour = payRate;
      this.position = position;
      employeeId = GenerateUniqueSerial();
      addAddress(homeAddress);
      employeeRoster.Add(employeeId, this);
    }

    static long GenerateUniqueSerial()
    {
      long randomSerial;
      Random rnd = new Random();

      byte[] buf = new byte[8];
      rnd.NextBytes(buf);
      long longRand = BitConverter.ToInt64(buf, 0);

      long result = (Math.Abs(longRand % (2000000000000000 - 1000000000000000)) + 1000000000000000);
      long random_seed = (long)rnd.Next(1000, 5000);
      random_seed = random_seed * result + rnd.Next(1000, 5000);
      randomSerial = (long)(random_seed / 655) % 10000000000000001;

      while (employeeRoster.ContainsKey(randomSerial))
      {
        random_seed = (long)rnd.Next(1000, 5000);
        random_seed = random_seed * result + rnd.Next(1000, 5000);
        randomSerial = (long)(random_seed / 655) % 10000000000000001;
      }

      return randomSerial;
    }
  }
}
