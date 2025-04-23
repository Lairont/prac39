using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class TextBook : IBook
    {
        string title, author, subject;
        int year;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Subject { get => subject; set => subject = value; }
        public int Year { get => Year1; set => Year1 = value; }
        public int Year1 { get => year; set => year = value; }

        public TextBook(string title, string author, int year, string subject)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.Subject = subject;
        }

        public static TextBook Enter()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Предмет: ");
            string subject = Console.ReadLine();
            return new TextBook(title, author, year, subject);
        }

        public void Info()
        {
            Console.WriteLine($"Название: {Title}\nАвтор: {Author}\nГод издания: {Year}\nПредмет: {Subject}");
        }
    }
}
