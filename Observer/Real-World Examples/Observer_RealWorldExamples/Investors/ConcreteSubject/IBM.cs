using Investors.Subject;

namespace Investors.ConcreteSubject
{
    // The "ConcreteSubject" class
    public class IBM : Stock
    {
        public IBM(string symbol, decimal price) : base(symbol, price)
        {
        }
    }
}
