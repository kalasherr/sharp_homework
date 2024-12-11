using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напиши свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.ReadKey();
        }
    }
}
