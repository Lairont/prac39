using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public class Company
    {
        private List<IEmployee> employees = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
            Console.WriteLine($"Сотрудник {employee.GetType().Name} добавлен.");
        }
        public void RemoveEmployee(string name)
        {
            var employeeToRemove = employees.FirstOrDefault(e => e.Name == name);

            if (employeeToRemove != null)
            {
                employees.Remove(employeeToRemove);
                Console.WriteLine($"Сотрудник {name} удален.");
            }
        }
        public void DisplayEmployees()
        {
            Console.WriteLine();
            foreach (var employee in employees)
            {
                employee.Info();
            }
            Console.WriteLine();
        }
    }
}
