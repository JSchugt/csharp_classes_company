using System;
using System.Collections.Generic;
namespace Classes
{
    public class Company
    {
        public Company(string Name, DateTime CreatedOn)
        {
            this.Name = Name;
            this.CreatedOn = CreatedOn;
        }
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> employeeList = new List<Employee>();

        public void addEmployee(Employee newGuy)
        {
            employeeList.Add(newGuy);
        }

        public void ListEMployeess()
        {
            foreach (Employee item in employeeList)
            {
                Console.WriteLine($"{item.FirstName} works for Acme as {item.Title} since {item.startDate.ToShortDateString()}");
            }
        }

        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
    }
}