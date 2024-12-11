using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLabs3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("task 4.1");
            Console.WriteLine("enter day (1-365)");
            DateTime data = Convert.ToDateTime("01.01.2022");
            int num = Convert.ToInt32(Console.ReadLine());
            data = data.AddDays(num - 1);
            Console.WriteLine(data.ToString("d MMMM"));



            Console.WriteLine();
            Console.WriteLine("task 4.2");
            Console.WriteLine("enter day (1-365)");
            DateTime date1 = Convert.ToDateTime("01.01.2022");
            int num1 = Convert.ToInt32(Console.ReadLine());
            bool accept = false;
            while (accept != true)
            {
                if (num1 < 1 || num1 > 365)
                {
                    Console.WriteLine("please, enter correct number 1-365");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {                  
                    date1 = date1.AddDays(num1 - 1);
                    Console.WriteLine(date1.ToString("d MMMM"));
                    accept = true;
                }
            }
            Console.WriteLine();


            Console.WriteLine("task 4.1.1");
            Console.WriteLine("enter day 1-365");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());
            DateTime date2 = Convert.ToDateTime("01.01.2022");
            accept = false;
            while (accept!=true)
            {
                if (num2 < 1 || num2 > 365)
                {
                    Console.WriteLine("please, enter correct number (1-365)");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    date2 = date2.AddDays(num2 - 1);
                    Console.WriteLine(date2.ToString("d MMMM"));
                    accept = true;
                }
            }           
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"{year} leap year ");
            }
            else
            {
                Console.WriteLine($"{year} non-leap year ");
            }
            Console.WriteLine();
            Console.ReadKey();


        }


    }
}