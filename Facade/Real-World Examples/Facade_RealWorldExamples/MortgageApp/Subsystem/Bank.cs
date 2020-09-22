using System;

namespace MortgageApp.Subsystem
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, decimal amount)
        {
            Console.WriteLine("Check bank for {0}", customer.Name);
            return true;
        }
    }
}
