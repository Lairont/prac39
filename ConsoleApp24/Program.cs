using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            while (true)
            {
                Console.WriteLine("1. Добавить сотрудника\n" +
                                  "2. Удалить сотрудника\n" +
                                  "3. Просмотреть всех сотрудников\n" +
                                  "4. Выход");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddEmployeeMenu(company);
                        break;
                    case "2":
                        RemoveEmployeeMenu(company);
                        break;
                    case "3":
                        company.DisplayEmployees();
                        break;
                    case "4":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Ошибка.");
                        break;
                }
            }
        }
        static void AddEmployeeMenu(Company company)
        {
            Console.WriteLine("1. Сотрудник с полным рабочим днем\n" +
                              "2. Сотрудник с неполным рабочим днем\n" +
                              "3. Подрядчик");

            Console.Write("Выберите тип сотрудника: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    company.AddEmployee(FullTimeEmployee.Enter());
                    break;
                case "2":
                    company.AddEmployee(PartTimeEmployee.Enter());
                    break;
                case "3":
                    company.AddEmployee(Contractor.Enter());
                    break;
                default:
                    Console.WriteLine("Ошибка.");
                    break;
            }
        }
        static void RemoveEmployeeMenu(Company company)
        {
            Console.Write("Введите имя сотрудника: ");
            string name = Console.ReadLine();
            company.RemoveEmployee(name);
        }
    }

}
