using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
  class Program
  {
    static void Main(string[] args)
    { 
      //*********************************
      //******* Task3 Test Code *********
      //*********************************
      Employee hrRep = new HR();

      hrRep.ClockIn();
      hrRep.Work();
      hrRep.SubmitDailyReport();
      Console.WriteLine(); //Line break
      //*********************************
      //******* Task3 Test Code *********
      //*********************************
      Employee employee1 = new Engineer();
      employee1.SubmitDailyReport();
      Console.WriteLine();
      Manager manager = new Manager();
      Intern intern = new Intern();

      Employee employee2 = manager;
      Employee employee3 = intern;

      employee2.ClockIn();
      employee2.Work();
      employee2.SubmitDailyReport();
      Console.WriteLine();
      employee3.ClockIn();
      employee3.Work();
      employee3.SubmitDailyReport();
      Console.WriteLine();

      Engineer engineer1 = (Engineer)employee1;
      if (engineer1 != null)
      {
        engineer1.SubmitDailyReport();
      } else
      {
        Console.WriteLine("Downcast Failed.");
      }

      Console.WriteLine();

      // Placeholder for list of employees
      List<Employee> employees = new List<Employee>();

      // Placeholder for adding employees to the list
      employees.Add(employee1);
      employees.Add(employee2);
      employees.Add(employee3);
      
      foreach (Employee employee in employees){
        if (employee is Engineer){
          Console.WriteLine("This is an Engineer.");
        }
        else if (employee is Intern){
          Console.WriteLine("This is an Intern.");
        }
        else if (employee is Manager){
          Console.WriteLine("This is an Manager.");
        }
        employee.ClockIn();
        employee.Work();
        employee.SubmitDailyReport();
        Console.WriteLine();
      }
    }
  }
}