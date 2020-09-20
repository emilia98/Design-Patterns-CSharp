using Investors.Subject;

namespace Investors.Interface
{      
    // The 'Observer' interface
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
