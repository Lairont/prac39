using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public class PartTimeEmployee : IEmployee
    {
        private string name;
        private double hourRate;

        public PartTimeEmployee(string name, double hourRate)
        {
            Name = name;
            HourRate = hourRate;
        }

        public string Name { get => name; set => name = value; }
        public double HourRate { get => hourRate; set => hourRate = value; }
        public static PartTimeEmployee Enter()
        {
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Почасовая ставка: ");
            double hourlyRate = double.Parse(Console.ReadLine());
            return new PartTimeEmployee(name, hourlyRate);
        }
        public void Info()
        {
            Console.WriteLine($"Имя: {Name}\nПочасовая ставка: {HourRate} руб/час");
        }
    }
}
