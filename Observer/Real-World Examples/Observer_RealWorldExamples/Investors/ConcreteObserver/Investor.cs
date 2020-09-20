using Investors.Interface;
using Investors.Subject;
using System;

namespace Investors.ConcreteObserver
{
    public class Investor : IInvestor
    {
        private readonly string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1} change to {2:C}", this.name, stock.Symbol, stock.Price);
        }
    }
}
