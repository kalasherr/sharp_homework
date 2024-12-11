using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dz1510
{
    internal class Program
    {
        enum temp
        {
            удаленный = 0, тряпка, паинька, спокойный, среднячок, козел, скотина, быдло, чмо, ублюдина, маньяк
        }
        //enum exam
        //{
        //    math_russian_inf, math_russian_eng, math_russian_phys
        //}
        struct student
        {

            public string name;
            public string surname;
            public int birth;
            public string exams;
            public int points;
            public student(string name, string surname, int birth, string exams, int points)
            {

                this.name = name;
                this.surname = surname;
                this.birth = birth;
                this.exams = exams;
                this.points = points;
            }
        }
        struct tupoi
        {
            public string name;
            public long passport;
            public string trouble1;
            public int trouble2;
            public temp temp;
            public bool umnik;
            public tupoi(string name, long passport, string trouble1, int trouble2, temp temp, bool umnik)
            {
                this.name = name;
                this.passport = passport;
                this.trouble1 = trouble1;
                this.trouble2 = trouble2;
                this.temp = temp;
                this.umnik = umnik;
            }
        }
        //public string DictToString(Dictionary<string, string> dict)
        //{
        //    string toString = "";
        //    foreach (string key in dict.Keys)
        //    {
        //        toString += key + "=" + dict[key];
        //    }
        //    return toString;
        //}
        public static void Beer(int[] bears, int[] schollers)
        {
            int bearpts = 0;
            int schollerpts = 0;
            for (int bearsind = 0; bearsind < bears.Length; bearsind++)
            {
                if (schollers[bearsind] == 5)
                {
                    bearpts++;
                    Console.WriteLine("+1 b");
                }
            }
            for (int schollerind = 0; schollerind < schollers.Length; schollerind++)
            {
                if (schollers[schollerind] == 5)
                {
                    schollerpts++;
                    Console.WriteLine("+1 s");
                }
            }
            if (bearpts == schollerpts)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }
        }
        static void Main(string[] args)
        {
            student stud1 = new student("Klonov1", "Klon", 2004, "math rus inf", 251);
            student stud2 = new student("Klonov2", "Klon", 2004, "math rus inf", 252);
            student stud3 = new student("Klonov3", "Klon", 2004, "math rus phys", 253);
            student stud4 = new student("Klonov4", "Klon", 2004, "math rus phys", 254);
            student stud5 = new student("Klonov5", "Klon", 2004, "math rus phys", 255);
            student stud6 = new student("Klonov6", "Klon", 2004, "math rus phys", 256);
            student stud7 = new student("Klonov7", "Klon", 2004, "math rus phys", 257);
            student stud8 = new student("Klonov8", "Klon", 2004, "math rus phys", 258);
            student stud9 = new student("Klonov9", "Klon", 2004, "math rus phys", 259);
            student stud10 = new student("Klonov10", "Klon", 2004, "math rus phys", 260);
            Console.WriteLine("task1");
            var Students = new Dictionary<string, student>()
            {
                ["Klonov1 Klon"] = stud1,
                ["Klonov2 Klon"] = stud2,
                ["Klonov3 Klon"] = stud3,
                ["Klonov4 Klon"] = stud4,
                ["Klonov5 Klon"] = stud5,
                ["Klonov6 Klon"] = stud6,
                ["Klonov7 Klon"] = stud7,
                ["Klonov8 Klon"] = stud8,
                ["Klonov9 Klon"] = stud9,
                ["Klonov10 Klon"] = stud10,
            };
            Console.WriteLine("Choose option: create, delete or sort");
            string choose = Console.ReadLine();
            string choose1 = choose.ToLower();
            if (choose1 == "create")
            {
                Console.WriteLine("enter surname, name,age of birth, your exams, your points");
                string surname = Console.ReadLine();
                string name = Console.ReadLine();
                string birth_toparse = Console.ReadLine();
                try
                {
                    int birth = Convert.ToInt32(birth_toparse);
                }
                catch (FormatException)
                {
                    Environment.Exit(0);
                }
                string exams = Console.ReadLine();
                string points_toparse = Console.ReadLine();
                try
                {
                    int points = Convert.ToInt32(points_toparse);
                }
                catch (FormatException)
                {
                    Environment.Exit(0);
                }
                student new_student = new student(surname, name, Convert.ToInt32(birth_toparse), exams, Convert.ToInt32(points_toparse));
                Students.Add(surname + " " + name, new_student);
            }
            else if (choose1 == "delete")
            {
                Console.WriteLine("Enter Surname Name");
                string surname_todelete = Console.ReadLine();
                Students.Remove(surname_todelete);
            }
            //else if (choose1 == "sort")
            //{

            //}
            //foreach (studemt in Students
            //{

            //}
            foreach (var p in Students)
            {
                Console.WriteLine( p.Value.surname + " " + p.Value.name + " " + p.Value.birth + " " + p.Value.points);
            }

            //string stud1_toprint = (stud1.surname + " " + stud1.name + " " + stud1.birth + " " + stud1.exams + " " + stud1.points);
            //string stud2_toprint = (stud2.surname + " " + stud2.name + " " + stud2.birth + " " + stud2.exams + " " + stud2.points);
            //string stud3_toprint = (stud3.surname + " " + stud3.name + " " + stud3.birth + " " + stud3.exams + " " + stud3.points);
            //string stud4_toprint = (stud4.surname + " " + stud4.name + " " + stud4.birth + " " + stud4.exams + " " + stud4.points);
            //string stud5_toprint = (stud5.surname + " " + stud5.name + " " + stud5.birth + " " + stud5.exams + " " + stud5.points);
            //string stud6_toprint = (stud6.surname + " " + stud6.name + " " + stud6.birth + " " + stud6.exams + " " + stud6.points);
            //string stud7_toprint = (stud7.surname + " " + stud7.name + " " + stud7.birth + " " + stud7.exams + " " + stud7.points);
            //string stud8_toprint = (stud8.surname + " " + stud8.name + " " + stud8.birth + " " + stud8.exams + " " + stud8.points);
            //string stud9_toprint = (stud9.surname + " " + stud9.name + " " + stud9.birth + " " + stud9.exams + " " + stud9.points);
            //string stud10_toprint = (stud10.surname + " " + stud10.name + " " + stud10.birth + " " + stud10.exams + " " + stud10.points);
            //string[] string_students = { stud1_toprint, stud1_toprint, stud1_toprint, stud1_toprint, stud1_toprint , stud1_toprint , stud1_toprint , stud1_toprint , stud1_toprint , stud1_toprint };

            Console.WriteLine("task2");
            int[] bears = { 3, 5, 1, 3, 6, 7, 3, 5, 5 };
            int[] schollers = { 3, 5, 7, 2, 5, 5, 1, 2, 0 };
            Beer(bears, schollers);
            Console.WriteLine("task3");
            tupoi zh1 = new tupoi("IlyaR", 3402384029384, "ponos", 3, (temp)10, false);
            tupoi zh2 = new tupoi("Andrew", 43284923849, "ponos", 2, (temp)3, true);
            tupoi zh3 = new tupoi("Aliya", 4239842390413, "ponos", 3, (temp)4, true);
            tupoi zh4 = new tupoi("Halil", 137461387, "ponos", 2, (temp)7, true);
            tupoi zh5 = new tupoi("IlyaB", 347938234892374, "ponos", 1, (temp)5, true);
            tupoi zh6 = new tupoi("Kamil", 1384772364723, "ponos", 2, (temp)2, true);
            tupoi zh7 = new tupoi("Azat", 34727342343, "ponos", 3, (temp)6, true);
            var zina = new List<tupoi>
            { zh1,zh2,zh3,zh4,zh5,zh6,zh7 };
            var queue1 = new List<tupoi> { };
            var queue2 = new List<tupoi> { };
            var queue3 = new List<tupoi> { };
            Random rand = new Random();
            int queue = 0;


            foreach (var zhitel in zina)
            {
                if (Convert.ToInt32(zhitel.temp) > 4)
                {
                    if (zhitel.umnik == false)
                    {
                        queue = rand.Next(1, 3);
                        switch (queue)
                        {
                            case 1:
                                {
                                    queue1.Add(zhitel);
                                    break;
                                }
                            case 2:
                                {
                                    queue2.Add(zhitel);
                                    break;
                                }
                            case 3:
                                {
                                    queue3.Add(zhitel);
                                    break;
                                }
                        }
                    }
                    else
                    {
                        switch (zhitel.trouble2)
                        {
                            case 1:
                                {
                                    queue1.Add(zhitel);
                                    break;
                                }
                            case 2:
                                {
                                    queue2.Add(zhitel);
                                    break;
                                }
                            case 3:
                                {
                                    queue3.Add(zhitel);
                                    break;
                                }
                        }
                    }
                }
            }

            foreach (var zh in zina)
            {
                if (Convert.ToInt32(zh.temp)<5)
                {
                    if (zh.umnik == false)
                    {
                        queue = rand.Next(1, 3);
                        switch (queue)
                        {
                            case 1:
                                {
                                    queue1.Add(zh);
                                    break;
                                }
                            case 2:
                                {
                                    queue2.Add(zh);
                                    break;
                                }
                            case 3:
                                {
                                    queue3.Add(zh);
                                    break;
                                }
                        }
                    }
                    else
                    {
                        switch (zh.trouble2)
                        {
                            case 1:
                                {
                                    queue1.Add(zh);
                                    break;
                                }
                            case 2:
                                {
                                    queue2.Add(zh);
                                    break;
                                }
                            case 3:
                                {
                                    queue3.Add(zh);
                                    break;
                                }
                        }
                    }
                }
            }
            Console.WriteLine("queue1:");
            foreach (var zhitel1 in queue1)
            {
                Console.WriteLine(zhitel1.name + " " + zhitel1.passport + " " + zhitel1.trouble1);
            }
            Console.WriteLine("queue2:");
            foreach (var zhitel2 in queue2)
            {
                Console.WriteLine(zhitel2.name + " " + zhitel2.passport + " " + zhitel2.trouble1);
            }
            Console.WriteLine("queue3:");
            foreach (var zhitel3 in queue3)
            {
                Console.WriteLine(zhitel3.name + " " + zhitel3.passport + " " + zhitel3.trouble1);
            }
        }
    }
}




