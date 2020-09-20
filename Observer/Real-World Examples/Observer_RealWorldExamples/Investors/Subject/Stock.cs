using Investors.Interface;
using System;
using System.Collections.Generic;

namespace Investors.Subject
{
    // The "Subject" abstract class
    public abstract class Stock
    {
        private string symbol;
        private decimal price;
        private List<IInvestor> investors = new List<IInvestor>();

        public Stock(string symbol, decimal price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            this.investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            this.investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in this.investors)
            {
                investor.Update(this);
            }

            Console.WriteLine();
        }

        // Gets or sets the price
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    Notify();
                }
            }
        }

        // Gets the symbol
        public string Symbol => this.symbol;
    }
}
