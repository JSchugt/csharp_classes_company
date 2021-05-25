using System;

namespace Classes
{
    public class Employee
    {
        public Employee(string first, string last, string title, DateTime date)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Title = title;
            this.startDate = date;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime startDate { get; }
    }
}