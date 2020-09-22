using ChemicalCompound.Adaptee;
using ChemicalCompound.Target;
using System;

namespace ChemicalCompound.Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class RichCompound : Compound
    {
        private ChemicalDatabank _bank;

        // Constructor
        public RichCompound(string name) : base(name)
        {
        }

        public override void Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank();

            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _molecularFormula = _bank.GetMolecularStructure(_chemical);
            _molecularWeight = _bank.GetMolecularWeight(_chemical);

            base.Display();

            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight: {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
    }
}
