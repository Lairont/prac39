using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class NonFictionBook : IBook
    {
        private string title, author, theme;
        private int year;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Theme { get => theme; set => theme = value; }
        public int Year { get => year; set => year = value; }

        public NonFictionBook(string title, string author, int year, string theme)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.Theme = theme;
        }

        public static NonFictionBook Enter()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Тема: ");
            string theme = Console.ReadLine();
            return new NonFictionBook(title, author, year, theme);
        }

        public void Info()
        {
            Console.WriteLine($"Название: {Title}\nАвтор: {Author}\nГод издания: {Year}\nТема: {Theme}");
        }
    }
}
