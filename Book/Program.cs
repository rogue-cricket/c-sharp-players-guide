using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This isn't a Try It Out! per se, but following allong with the Book class example starting on page 112.

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "J.K. Rowling");
            book.SetTitle("Harry Potter and the Thingy");
            Console.WriteLine(book.GetTitle());
            Console.ReadKey();
        }
    }
}
