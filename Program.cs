using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company acme = new Company("acme", new DateTime(2021, 02, 17));
            acme.addEmployee(new Employee("Jeremiah", "Schugt", "Awesome", new DateTime(2021, 4, 15)));
            acme.addEmployee(new Employee("Dakota", "Upchurch", "Manager", new DateTime(2021, 4, 24)));
            acme.addEmployee(new Employee("Preson", "Shotts", "Janitor", new DateTime(2021, 4, 25)));
            acme.ListEMployeess();
            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}