using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var book = new Book("Pod Igoto", "Vazov", 15.6);
        var goldenBook = new GoldenEditionBook("Bai Ganio", "Konstantinov", 25);
        
        Console.WriteLine(book.ToString());

        Console.WriteLine(goldenBook.ToString());
        
    }
}
