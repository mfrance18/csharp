using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company
            {
                Name = "Matt's Company"
            };



            // Create three employees

            Employee matt = new Employee
            {
                FirstName = "Matt",
                LastName = "France",
                Title = "Master of Universe",
                StartDate = new DateTime(2021, 11, 17)
            };

            // Assign the employees to the company
            myCompany.Employees.Add(matt);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */



        }
    }
}
