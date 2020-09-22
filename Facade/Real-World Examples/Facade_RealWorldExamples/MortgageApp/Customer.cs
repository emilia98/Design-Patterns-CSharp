namespace MortgageApp
{
    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
    {
        private string _name;

        // Constructor
        public Customer(string name)
        {
            _name = name;
        }

        // Gets the name
        public string Name => _name;
    }
}
