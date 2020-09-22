using MortgageApp.Subsystem;
using System;

namespace MortgageApp.Facade
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer customer, decimal amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan", customer.Name, amount);
            Console.WriteLine();

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLOans(customer))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
