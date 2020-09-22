using System;

namespace MortgageApp.Subsystem
{
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    public class Loan
    {
        public bool HasNoBadLOans(Customer customer)
        {
            Console.WriteLine("Check loans for {0}", customer.Name);
            return true;
        }
    }
}
