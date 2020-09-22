using System;

namespace MortgageApp.Subsystem
{
    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine("Check credit for {0}", customer.Name);
            return true;
        }
    }
}
