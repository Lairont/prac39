using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        int Year { get; set; }
        void Info();
    }
}
