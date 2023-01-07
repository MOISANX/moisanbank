using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moisanBank1
{
    internal class Program
    {
       


        static void Main(string[] args)
        {
            Console.Title = "Banco Versão MOISANX";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            new Bank().Menu();

        }
    }
}
