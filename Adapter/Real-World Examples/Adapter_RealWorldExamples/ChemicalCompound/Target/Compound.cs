using System;

namespace ChemicalCompound.Target
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        // Constructor
        public Compound(string chemical)
        {
            _chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Compound: {0} ------", _chemical);
        }
    }
}
