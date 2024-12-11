using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace dz_30._09
{
    enum Cards
    {
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9,
        ten = 10,
        jack = 11,
        queen = 12,
        king = 13,
        ace = 14

    }
    enum week
    {
        monday = 1,
        tuesday = 2,
        wednesday = 3,
        thursday = 4,
        friday = 5,
        saturday = 6,
        sunday = 7
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задание 1");
            //Console.WriteLine("Введите размер форточки");
            //double okno1 = Convert.ToDouble(Console.ReadLine());
            //double okno2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите радиус головы");
            //double head1 = Convert.ToDouble(Console.ReadLine());
            //double head2 = head1 / 2;
            //if (okno1 < okno2)
            //{
            //    if (okno1/2 >= head2+1)
            //    {
            //        Console.WriteLine("Голова пролезет");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Голова не пролезет");
            //    }
            //}
            //else
            //{
            //    if (okno2 / 2 >= head2 + 1)
            //    {
            //        Console.WriteLine("Голова пролезет");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Голова не пролезет");
            //    }
            //}


            //Console.WriteLine("Задание 2");
            //Console.WriteLine("Введите число n ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //while (i<10)
            //{
            //    i++;
            //    Console.Write(n * i + " ");
            //}


            //Console.WriteLine("Задание 3");
            //Console.WriteLine("Введите число");
            //double bumbang = (Convert.ToDouble(Console.ReadLine()))%15;
            //switch (bumbang)
            //{
            //    case 0:
            //        Console.WriteLine("БумБэнг");
            //        break;
            //    case 3:
            //        Console.WriteLine("Бум");
            //        break;
            //    case 6:
            //        Console.WriteLine("Бум");
            //        break;
            //    case 9:
            //        Console.WriteLine("Бум");
            //        break;
            //    case 12:
            //        Console.WriteLine("Бум");
            //        break;
            //    case 5:
            //        Console.WriteLine("Бэнг");
            //        break;
            //    case 10:
            //        Console.WriteLine("Бэнг");
            //        break;
            //    default:
            //        Console.WriteLine("Мимо");
            //        break;
            //}


            //Console.WriteLine("Задание 4");
            //Console.Write("Введите строку: ");
            //string text = Console.ReadLine();
            //if (text.ToUpper() == text)
            //{ Console.WriteLine("True"); }
            //else 
            //{
            //    Console.WriteLine("false");
            //}


            //Console.WriteLine("Задание 5");
            //Console.WriteLine("Введите количество");
            //int sheep = Convert.ToInt32(Console.ReadLine());
            //int sheep1 = 1;
            //while (sheep1 < sheep)
            //{
            //    Console.Write(sheep1 + (" овца... "));
            //    sheep1++;
            //    if (sheep1%7==0)
            //    {
            //        Console.WriteLine();
            //    }
            //}


            //    Console.WriteLine("task 6");
            //    Console.WriteLine("enter numbers");
            //    double sum = 0;
            //    int num = 0;
            //govnocode:; //да простит меня бог
            //    num++;
            //    try
            //    {
            //        double num1 = Convert.ToUInt32(Console.ReadLine());
            //        sum = sum + num1;
            //        goto govnocode;
            //    }
            //    catch
            //    {
            //        Console.WriteLine(sum / num);
            //    }

            //Console.WriteLine("task 7");
            //Console.WriteLine("enter card number");
            //switch (Convert.ToInt32(Console.ReadLine()))
            //{
            //    case 6:
            //        {
            //            Console.WriteLine(Cards.six);
            //            break;
            //        }
            //    case 7:
            //        {
            //            Console.WriteLine(Cards.seven);
            //            break;
            //        }
            //    case 8:
            //        {
            //            Console.WriteLine(Cards.eight);
            //            break;
            //        }
            //    case 9:
            //        {
            //            Console.WriteLine(Cards.nine);
            //            break;
            //        }
            //    case 10:
            //        {
            //            Console.WriteLine(Cards.ten);
            //            break;
            //        }
            //    case 11:
            //        {
            //            Console.WriteLine(Cards.jack);
            //            break;
            //        }
            //    case 12:
            //        {
            //            Console.WriteLine(Cards.queen);
            //            break;
            //        }
            //    case 13:
            //        {
            //            Console.WriteLine(Cards.king);
            //            break;
            //        }
            //    case 14:
            //        {
            //            Console.WriteLine(Cards.ace);
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("It is not a card!");
            //            break;
            //        }
            //}


            //Console.WriteLine("task 8");
            //int count = 0;
            //string[] bag = { };
            //foreach (string toy in bag)
            //{
            //    if (toy == "Barbie Doll" || toy == "Hello Kitty")
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Dolls: " + count);


            //Console.WriteLine("task 9");
            //Console.WriteLine("enter card number");
            //switch (Convert.ToByte(Console.ReadLine()))
            //{
            //    case 1:
            //        {
            //            Console.WriteLine(week.monday);
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine(week.tuesday);
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine(week.wednesday);
            //            break;
            //        }
            //    case 4:
            //        {
            //            Console.WriteLine(week.thursday);
            //            break;
            //        }
            //    case 5:
            //        {
            //            Console.WriteLine(week.friday);
            //            break;
            //        }
            //    case 6:
            //        {
            //            Console.WriteLine(week.saturday);
            //            break;
            //        }
            //    case 7:
            //        {
            //            Console.WriteLine(week.sunday);
            //            break;
            //        }
            //}


            Console.WriteLine("task 10");
            int[] array1 = { 10, 8, 12, 15, 23, 9, -1 };
            int comp;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i] > array1[j])
                    {
                        comp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = comp;
                    }
                }
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i]+" ");
            }
            Console.WriteLine();


            Console.WriteLine("task 11");
            Console.WriteLine("enter numbers");
            int o = 0;
            double max = 0;
            double u;
            bool progression = true;
            bool zero = false;
            while (o<10)
            {
                o++;
                u = Convert.ToInt16(Console.ReadLine());
                if (u<0)
                {
                    Console.WriteLine(o+"-ый/ой/ий элемент прерывает последовательность");
                    zero = true;
                    break;

                }
                if (u>max)
                {
                    max = u;
                }
                else
                {
                    progression = false;
                }
                
            }
            if (zero == false)
            {
                Console.WriteLine(progression);
            }
        }
    }
}