using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Decorator.Library_Example
{
    class TestProgram
    {
        static void Main2()
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            Borrowable borrowBook = new Borrowable(book);
            borrowBook.BorrowItem("Test customer #1");
            borrowBook.BorrowItem("Test customer #2");

            borrowBook.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
