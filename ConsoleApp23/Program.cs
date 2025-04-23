using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static Library library = new Library();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Добавить книгу\n" +
                                  "2. Удалить книгу\n" +
                                  "3. Просмотреть книги\n" +
                                  "4. Выход");

                Console.Write("Выберите действие: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddBookMenu();
                        break;
                    case "2":
                        DeleteBook();
                        break;
                    case "3":
                        ViewBooks();
                        break;
                    case "4":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Ошибка.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddBookMenu()
        {
            Console.WriteLine("1. Художественная книга\n" +
                              "2. Научная книга\n" +
                              "3. Учебник\n"); 

            Console.Write("Выберите тип книги: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    library.AddFictionBook(FictionBook.Enter());
                    break;
                case "2":
                    library.AddNonFictionBook(NonFictionBook.Enter());
                    break;
                case "3":
                    library.AddTextBook(TextBook.Enter());
                    break;
                default:
                    Console.WriteLine("Ошибка.");
                    break;
            }
        }

        static void DeleteBook()
        {
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();

            bool isDeleted = library.DeleteBook(title);
            if (isDeleted)
            {
                Console.WriteLine($"Книга {title} удалена.");
            }
            else
            {
                Console.WriteLine($"Книга с названием {title} не найдена.");
            }
        }

        static void ViewBooks()
        {
            library.InfoBooks();
        }
    }
}