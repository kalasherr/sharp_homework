using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            double e = Math.E;
            e = Math.Round(e, 1);//округление до 1 знака после запятой
            Console.WriteLine(e);
            

            Console.WriteLine("Задание 2");
            Console.WriteLine("10");
            Console.WriteLine("50");
            

            Console.WriteLine("Задание 3.1");//вариант на случай, если нужно было сделать ввод-вывод
            Console.Write("Введите 1ое число:");
            string s1 = (Console.ReadLine());
            Console.Write("Введите 2ое число:");
            string s2 = Console.ReadLine();
            Console.Write("Введите 3е число:");
            string s3 = Console.ReadLine();
            Console.Write("Введите 4ое число:");
            string s4 = Console.ReadLine();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);


            Console.WriteLine("Задание 3.2");// на случай если нужны рандомные числа
            var r1 = new Random(); 
            // for (int i = 0; i <= 3; i++)
            Console.WriteLine(r1.Next());
            Console.WriteLine(r1.Next());
            Console.WriteLine(r1.Next());
            Console.WriteLine(r1.Next());
            Console.WriteLine("Заданиe 4");
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine();
            int number1 = Convert.ToInt32(number);
            number1 = number1 + 10;
            Console.WriteLine(number1);
            Console.ReadKey();


            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите сторону:");
            int storona = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(storona*4);
            Console.ReadKey();


            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите радиус");
            double radius =Convert.ToDouble(Console.ReadLine());
            double area = radius * radius * Math.PI;
            double lenght = radius * 2 * Math.PI;
            Console.Write("S=");
            Console.WriteLine(area);
            Console.Write("l=");
            Console.WriteLine(lenght);
            Console.ReadKey();


            Console.WriteLine("Задание 7");
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(x);
            Console.Write("y=");
            Console.WriteLine(y);


            Console.WriteLine("Задание 8");
            Console.Write("Введите первое основание");
            double osnovanie1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе основание:");
            double osnovanie2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToString(osnovanie1 + osnovanie2+ 2*Math.Sqrt((osnovanie1 - osnovanie2)* (osnovanie1 - osnovanie2) / 4 + height*height)));
            Console.ReadKey();


            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите стоимость и кол-во каждого продукта в порядке стоимость1-масса1-стоимость2-масса2-...");
            double candy_price = Convert.ToDouble(Console.ReadLine());
            double candy_weight = Convert.ToDouble(Console.ReadLine());
            double cookies_price = Convert.ToDouble(Console.ReadLine());
            double cookies_weight = Convert.ToDouble(Console.ReadLine());
            double apple_price = Convert.ToDouble(Console.ReadLine());
            double apple_weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сумма:");
            Console.WriteLine(candy_price * candy_weight + cookies_price * cookies_weight + apple_price * apple_weight);
            Console.ReadKey();


            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир" + " " + "Труд" + " " + "Май");
            Console.WriteLine("Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("         Май");


            //Console.WriteLine("Задание 11");
            //Console.WriteLine("Введите 2 числа");
            //string type1 = GetType(Console.ReadLine();


            //Console.WriteLine("Задание 12");


            Console.WriteLine("задание 13");
            Console.Write("Введите число:");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {num01}");
            Console.ReadKey();


            Console.WriteLine("Задание 14");
            Console.WriteLine("2 кг\n13 17");


            Console.WriteLine("Задание 15");
            var r2 = new Random();
            Console.WriteLine(r2.Next());
            Console.WriteLine(r2.Next());
            Console.WriteLine(r2.Next());
            Console.WriteLine(r2.Next());
            Console.ReadKey();


            Console.WriteLine("Задание 16");
            Console.WriteLine("Введите a,b и с:");
            double a1 = Convert.ToInt32(Console.ReadLine());
            double b1 = Convert.ToInt32(Console.ReadLine());
            double c1 = Convert.ToInt32(Console.ReadLine());
            double x01 = (Math.Sqrt(b1 * b1 - 4 * a1 * c1) - b1) / 2 / a1;
            double x02 = (-Math.Sqrt(b1 * b1 - 4 * a1 * c1) - b1) / 2 / a1;
            Console.WriteLine($"x1={x01}, x2={x02}");
            Console.ReadKey();


            Console.WriteLine("Задание 17");
            Console.Write("Введите первое число:");
            double first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            double second = Convert.ToInt32(Console.ReadLine());
            double arifm = (first + second) / 2;
            double geom = Math.Sqrt(first * second);
            Console.Write("Ср.арифметическое:");
            Console.WriteLine(arifm);
            Console.Write("Ср.геометрическое:");
            Console.WriteLine(geom);
            Console.ReadKey();


            Console.WriteLine("Задание 18");
            Console.WriteLine("Введите х1,у1,х2,у2");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double x0 = x1 - x2;
            double y0 = y1 - y2;
            double lenght1 = Math.Sqrt(x0 * x0 + y0 * y0);
            Console.Write("Расстояние между точками = ");
            Console.WriteLine(lenght1);
            Console.ReadKey ();


            Console.WriteLine("Задание 19a");
            Console.WriteLine("Введите 3 числа");
            double aa = Convert.ToDouble(Console.ReadLine());
            double aaa;
            double bb = Convert.ToDouble(Console.ReadLine());
            double bbb;
            double cc = Convert.ToDouble(Console.ReadLine());
            double ccc;
            aaa = bb;
            bbb = cc;
            ccc = aa;
            Console.WriteLine($"{aaa} {bbb} {ccc}");
            Console.ReadKey();


            Console.WriteLine("Задание 19б");
            Console.WriteLine("Введите 3 числа");
            double aa1 = Convert.ToDouble(Console.ReadLine());
            double aaa1;
            double bb1 = Convert.ToDouble(Console.ReadLine());
            double bbb1;
            double cc1 = Convert.ToDouble(Console.ReadLine());
            double ccc1;
            aaa1 = cc1;
            bbb1 = aa1;
            ccc1 = bb1;
            Console.WriteLine($"{aaa1} {bbb1} {ccc1}");
            Console.ReadKey();


            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите количество секунд");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine(sec / 3600+ ":" +(sec % 3600) / 60+":"+ sec % 60);
            Console.ReadKey();


            Console.WriteLine("Задание 21");
            Console.WriteLine("4");//кода легче не найдете


            Console.WriteLine("Задание 22");
            Console.Write("Напишите число:");
            int ocherednaya_peremennaya = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:" + ocherednaya_peremennaya % 10 * 100 + ocherednaya_peremennaya / 10);
            Console.ReadKey();


            Console.WriteLine("Задание 23");
            Console.Write("Напишите число:");
            int peremennaya = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Тысяч:" + peremennaya / 1000 + " Сотни:" + peremennaya / 100);
            Console.ReadKey();


            Console.WriteLine("Задание 24");
            Console.WriteLine("Введите четырехзначное число");
            int qwer = Convert.ToInt32(Console.ReadLine());
            Convert.ToInt32(e);
            int q = qwer / 1000;
            int w = qwer % 1000 / 100;
            e = qwer % 100 / 10;
            int r = qwer % 10;
            Console.WriteLine("а)" + r + e + w + q + " б)" + w + q + r + e + " в)" + q + e + w + r + " г)" + e + r + q + w);
            Console.ReadKey();


            Console.WriteLine("Задание 25");
            Console.Write("Введите еще одно число:");
            int p = Convert.ToInt32(Console.ReadLine());
            int p1 = p / 100;
            int p2 = p % 100 / 10;
            int p3 = p % 10;
            int p0 = p1 * 10 + p2 + p3 * 100;
            Console.WriteLine("Результат перестановки: " + p0);
            Console.ReadKey();


            //Console.WriteLine("Задание 28");
            //Console.WriteLine("Введите 3 числа");
            //int d1 = Convert.ToInt32(Console.ReadLine()).;
            //int d2 = Convert.ToInt32(Console.ReadLine());
            //int d3 = Convert.ToInt32(Console.ReadLine());
            //d1= d1 * d1;
            //d2= d2 * d2;    
            //d3= d3 * d3;
            //if (d1 - d2 > 0) &(d1 - d3 > 0);


            //Console.WriteLine("Задание 30");
            //Console.WriteLine("Введите коэффициенты a,b,c,d");
            //int k1 = Convert.ToInt32(Console.ReadLine());
            //int k2 = Convert.ToInt32(Console.ReadLine());
            //int k3 = Convert.ToInt32(Console.ReadLine());
            //int k4 = Convert.ToInt32(Console.ReadLine());
            //int o = 0;
            //while (o<101) do
            //    {
            //        o = o++;
            //        if (k1 * o * o * o + k2 * o * o + k3 * o + k4 == 0) 
            //            }
            Console.ReadKey();
        }
    }
}
