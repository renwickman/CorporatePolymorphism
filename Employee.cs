using System;

namespace CorporatePolymorphism
{
  // Placeholder for Employee class implementation
  public abstract class Employee
  {
    public virtual void SubmitDailyReport(){

    }

    public virtual void Work(){

    }

    public virtual void ClockIn(){
      Console.WriteLine("Employee clocks in.");
    }
  }
}
