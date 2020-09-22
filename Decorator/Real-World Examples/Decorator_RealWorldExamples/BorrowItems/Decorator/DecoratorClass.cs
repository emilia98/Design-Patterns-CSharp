using BorrowItems.Component;

namespace BorrowItems.Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class DecoratorClass : LibraryItem
    {
        protected LibraryItem _libraryItem;

        public DecoratorClass(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }

        public override void Display()
        {
            _libraryItem.Display();
        }
    }
}
