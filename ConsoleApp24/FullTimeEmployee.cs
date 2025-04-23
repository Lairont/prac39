using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public class FullTimeEmployee : IEmployee
    {
        private string name;
        private int salary;

        public FullTimeEmployee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public int Salary { get => salary; set => salary = value; }
        public string Name { get => name; set => name = value; }
        public static FullTimeEmployee Enter()
        {
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Зарплата: ");
            int salary = int.Parse(Console.ReadLine());
            return new FullTimeEmployee(name, salary);
        }

        public void Info()
        {
            Console.WriteLine($"Имя: {Name}\nЗарплата: {Salary} руб.");
        }
    }
}
