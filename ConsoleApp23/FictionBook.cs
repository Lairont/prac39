using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class FictionBook : IBook
    {
        private string title, author, genre;
        private int year;
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Year { get => year; set => year = value; }
        public FictionBook(string title, string author, int year, string genre)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.Genre = genre;
        }
        public static FictionBook Enter()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Жанр: ");
            string genre = Console.ReadLine();
            return new FictionBook(title, author, year, genre);
        }
        public void Info()
        {
            Console.WriteLine($"Название: {Title}\nАвтор: {Author}\nГод издания: {Year}\nЖанр: {Genre}");
        }
    }
}
