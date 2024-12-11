using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct alkash
    {
        public string name;
        public string surname;
        public int num;
        public string date;
        public string alko_category;
        public double volume;
        public alkash(string name, string surname, int num, string date, string alko_category, double volume)
        {
            this.name = name;
            this.surname = surname;
            this.num = num;
            this.date = date;
            this.alko_category = alko_category;
            this.volume = volume;

        }
    }
    struct user
    {
        public string name1;
        public string city;
        public string age;
        public string pin;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задание 1");
            //alkash stud1 = new alkash("Андрей", "Калашников", 1, "20.05.2005", "d", 0.0);
            //alkash stud2 = new alkash("Лейсан", "Фаррахова", 2, "24.08.2004", "с", 0.5);
            //alkash stud3 = new alkash("Камиль", "Ахметзянов", 3, "14.10.2004", "b", 1.5);
            //alkash stud4 = new alkash("Аделя", "Гильфанова", 4, "26.05.2004", "b", 2.0);
            //alkash stud5 = new alkash("Халиль", "Зиганшин", 5, "14.01.2004", "b", 2.5);
            //double alkosum = stud1.volume+stud2.volume+stud3.volume+stud4.volume+stud5.volume;
            //Console.WriteLine(stud1.name+" "+stud1.surname+" "+stud1.num+" "+stud1.date+" "+stud1.alko_category+" "+stud1.volume+" "+Convert.ToString((stud1.volume/alkosum)));
            //Console.WriteLine(stud2.name + " " + stud2.surname + " " + stud2.num + " " + stud2.date + " " + stud2.alko_category + " " + stud2.volume + " " + Convert.ToString((stud2.volume / alkosum)));
            //Console.WriteLine(stud3.name + " " + stud3.surname + " " + stud3.num + " " + stud3.date + " " + stud3.alko_category + " " + stud3.volume + " " +Convert.ToString((stud3.volume / alkosum)));
            //Console.WriteLine(stud4.name + " " + stud4.surname + " " + stud4.num + " " + stud4.date + " " + stud4.alko_category + " " + stud4.volume + " " + Convert.ToString((stud4.volume / alkosum)));
            //Console.WriteLine(stud5.name + " " + stud5.surname + " " + stud5.num + " " + stud5.date + " " + stud5.alko_category + " " + stud5.volume + " " +Convert.ToString((stud5.volume / alkosum)));
            //Console.ReadKey();


            //Console.WriteLine("Задание 2");
            //Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}" + "\n" +
            //$"byte: {byte.MinValue} ... {byte.MaxValue}" + "\n" +
            //$"short: {short.MinValue} ... {short.MaxValue}" + "\n" +
            //$"ushort: {ushort.MinValue} ... {ushort.MaxValue}" + "\n" +
            //$"int: {int.MinValue} ... {int.MaxValue}" + "\n" +
            //$"uint: {uint.MinValue} ... {uint.MaxValue}" + "\n" +
            //$"long: {long.MinValue} ... {long.MaxValue}" + "\n" +
            //$"ulong: {ulong.MinValue} ... {ulong.MaxValue}" + "\n" +
            //$"char: U+000 ... U+ffff" + "\n" +
            //$"float: {float.MinValue} ... {float.MaxValue}" + "\n" +
            //$"double: {double.MinValue} ... {double.MaxValue}" + "\n" +
            //"bool: true ... false" + "\n" +
            //$"decimal: {decimal.MinValue} ... {decimal.MaxValue}" + "\n" +
            //"string: Ограничено только системной памятью" + "\n" +
            //"object: Почти всё, что угодно" + "\n");


            //Console.WriteLine("Задание 3");
            //Console.WriteLine("Task 3");
            //user user1 = new user();
            //Console.WriteLine("Введите имя");
            //user1.name1 = Console.ReadLine();
            //Console.WriteLine("Введите город");
            //user1.city = Console.ReadLine();
            //Console.WriteLine("Введите возраст");
            //user1.age = Console.ReadLine();
            //Console.WriteLine("Введите PIN");
            //user1.pin = Console.ReadLine();
            //Console.WriteLine(user1.name1 + " " + user1.city + " " + user1.age + " " + user1.pin);


            //Console.WriteLine("Задание 4");
            //string[] name = Console.ReadLine().Split(' ');
            //Console.WriteLine($"{name[0][0].ToString().ToUpper()}.{name[1][0].ToString().ToUpper()}.");


            //Console.WriteLine("Задание 5");
            //Console.WriteLine("Enter whiskey price");
            //double whiskey = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter discount");
            //double discount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter holiday price");
            //double holiday = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You should buy " + Convert.ToString(Convert.ToInt32(holiday / (whiskey * discount/100))));


            //Console.WriteLine("Задание 6");
            //Console.WriteLine("Enter speed (km)");
            //double speed = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.Round(speed / 0.036));


            Console.WriteLine("Задание 7");
            Console.WriteLine("Task 7");
            string strInput = Console.ReadLine();
            StringBuilder strOutput = new StringBuilder();
            foreach (Char c in strInput.ToCharArray())
            {
                if (Char.IsLower(c))
                {
                    strOutput.Append(Char.ToUpper(c));
                }
                else
                {
                    strOutput.Append(Char.ToLower(c));
                }
            }
            Console.WriteLine(strOutput);
        }


    }
    
}
