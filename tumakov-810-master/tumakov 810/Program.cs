using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov_810
{
    internal class Program
    {
        static int task1(int a, int b)
        {
            return a > b ? a : b;
        }
        static void task2(ref string a, ref string b)
        {
            (a, b) = (b, a);
            Console.WriteLine(a + " " + b);
        }
 
        static int task4(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * task4(n - 1);
        }
        static void task111()
        {
            int nod;
            Console.WriteLine("введите первое число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int m = int.Parse(Console.ReadLine());
            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }

            nod = n;
            Console.WriteLine("НОД: " + nod);

        }
        static void task112()
        {
            Console.WriteLine("введите 3 числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int Nod = Math.Min(a, Math.Min(b, c));
            for (; Nod > 1; Nod--)
            {
                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                    break;
            }
            Console.WriteLine("NOD: " + Nod);
        }
        static void task12()
        {
            Console.WriteLine("введите номер числа");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("введите натуральное число");
            }
            else
            {
                int perv = 1;
                int vtor = 1;
                int sum;

                int j = 2;
                while (j <= num)
                {
                    sum = perv + vtor;
                    perv = vtor;
                    vtor = sum;
                    j++;
                }
                Console.WriteLine("Под номером " + num + " в ряде фибоначчи стоит число " + perv);
            }
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(task1(a, b));
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();               
            task2(ref s1, ref s2);
            Console.WriteLine("Task4");
            Console.Write("dведите число, факториал которого нужно вычислить: ");
 
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join("", task4(n)));
            task111();
            task112();
            task12();
            Console.ReadKey();
        }
    }
}