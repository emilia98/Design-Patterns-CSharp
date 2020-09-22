using BorrowItems.Component;
using BorrowItems.Decorator;
using System;
using System.Collections.Generic;

namespace BorrowItems.ConcreteDecorator
{
    /// <summary>
    /// The 'ConcreteDecorator' class 
    /// </summary>
    public class Borrowable : DecoratorClass
    {
        protected List<string> _borrowers = new List<string>();

        // Constructor
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
            _libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
            _libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in _borrowers)
            {
                Console.WriteLine(" borrower: {0}", borrower);
            }
        }
    }
}
