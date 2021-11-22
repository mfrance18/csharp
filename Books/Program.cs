using System;


namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book()
            {
                Name = "Harry Potter and the Chamber of Secrets",
                Author = "J.K. Rowling",
            };

            newBook.CheckOut();

            Console.WriteLine($"{newBook.Author} {newBook.Name}, Checked out?: {newBook.IsCheckedOut}");

        }
    }
}
