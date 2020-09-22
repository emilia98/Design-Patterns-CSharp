using BorrowItems.ConcreteComponent;
using BorrowItems.ConcreteDecorator;
using System;

namespace BorrowItems
{
    public class StartUp
    {
        static void Main()
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, the borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowVideo = new Borrowable(video);
            borrowVideo.BorrowItem("Customer #1");
            borrowVideo.BorrowItem("Customer #2");

            borrowVideo.Display();
        }
    }
}
