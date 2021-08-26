using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Dope Movies", new DateTime(2021, 08, 25));
            // Create three employees
            Employee Bob = new Employee();
            Bob.FirstName = "Bobby";
            Bob.LastName = "Bones";
            Bob.Title = "Door Boy";
            Bob.StartDate = new DateTime(2021, 08, 25);

            Employee Bill = new Employee();
            Bill.FirstName = "Billy";
            Bill.LastName = "Bongs";
            Bill.Title = "Movie Picker";
            Bill.StartDate = new DateTime(2021, 08, 25);

            Employee John = new Employee();
            John.FirstName = "Johnny";
            John.LastName = "Jones";
            John.Title = "Snack Getter";
            John.StartDate = new DateTime(2021, 08, 25);
            // Assign the employees to the company
            company.Employees.Add(Bob);
            company.Employees.Add(Bill);
            company.Employees.Add(John);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee employee in company.Employees)
            {
                company.ListEmployees(employee, company);
            }
        }
    }
}
