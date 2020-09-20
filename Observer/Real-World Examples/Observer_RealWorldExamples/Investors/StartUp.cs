using Investors.ConcreteObserver;
using Investors.ConcreteSubject;
using System;

namespace Investors
{
    public class StartUp
    {
        static void Main()
        {
            // Create IBM stock (Create concrete subject class)
            IBM ibm = new IBM("IBM", 120.00m);

            // Attach investors (Attach concrete observers)
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // The change in prices will notify investors
            ibm.Price = 120.10m;
            ibm.Price = 121.00m;
            ibm.Price = 120.50m;
            ibm.Price = 120.75m;

            Console.ReadKey();
        }
    }
}
