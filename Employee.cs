using System;

namespace Classes
{
    //declaring a class
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

    }
}
