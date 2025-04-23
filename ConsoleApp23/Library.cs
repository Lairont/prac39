using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Library
    {
        List<FictionBook> fictionBooks = new List<FictionBook>();
        List<NonFictionBook> nonFictionBooks = new List<NonFictionBook>();
        List<TextBook> textBooks = new List<TextBook>();

        public void AddFictionBook(FictionBook book)
        {
            fictionBooks.Add(book);
        }

        public void AddNonFictionBook(NonFictionBook book)
        {
            nonFictionBooks.Add(book);
        }

        public void AddTextBook(TextBook book)
        {
            textBooks.Add(book);
        }

        public bool DeleteBook(string title)
        {
            foreach (var book in fictionBooks)
            {
                if (book.Title == title)
                {
                    fictionBooks.Remove(book);
                    return true;
                }
            }
            foreach (var book in nonFictionBooks)
            {
                if (book.Title == title)
                {
                    nonFictionBooks.Remove(book);
                    return true;
                }
            }
            foreach (var book in textBooks)
            {
                if (book.Title == title)
                {
                    textBooks.Remove(book);
                    return true;
                }
            }
            return false;
        }
        public void InfoBooks()
        {
            if (fictionBooks.Count > 0)
            {
                Console.WriteLine("Художественные книги:");
                foreach (var book in fictionBooks)
                {
                    book.Info();
                    Console.WriteLine(); 
                }
            }

            if (nonFictionBooks.Count > 0)
            {
                Console.WriteLine("Научные книги:");
                foreach (var book in nonFictionBooks)
                {
                    book.Info();
                    Console.WriteLine(); 
                }
            }

            if (textBooks.Count > 0)
            {
                Console.WriteLine("Учебники:");
                foreach (var book in textBooks)
                {
                    book.Info();
                    Console.WriteLine(); 
                }
            }
        }
    }
}
