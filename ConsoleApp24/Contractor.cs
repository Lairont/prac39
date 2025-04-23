using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public class Contractor : IEmployee
    {
        private string name, contractDetails;

        public Contractor(string name, string contractDetails)
        {
            Name = name;
            ContractDetails = contractDetails;
        }

        public string Name { get => name; set => name = value; }
        public string ContractDetails { get => contractDetails; set => contractDetails = value; }
        public static Contractor Enter()
        {
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Детали контракта: ");
            string contractDetails = Console.ReadLine();
            return new Contractor(name, contractDetails);
        }
        public void Info()
        {
            Console.WriteLine($"Имя: {Name}\nКонтракт: {ContractDetails}");
        }
    }

}
