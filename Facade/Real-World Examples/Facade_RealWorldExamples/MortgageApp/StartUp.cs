using MortgageApp.Facade;
using System;

namespace MortgageApp
{
    public class StartUp
    {
        static void Main()
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for a customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000.00m);

            Console.WriteLine();
            Console.WriteLine("{0} has been {1}", customer.Name, eligible ? "Approved" : "Rejected");
        }
    }
}
