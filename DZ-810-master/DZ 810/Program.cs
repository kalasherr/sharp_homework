using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ_810
{
    public enum level
    {
        first, second, third, fourth, fifth
    }
    struct ded
    {
        public string name;
        public level trashtalk;
        public string[] insult;
        public short hit;
        public ded(string Name, level Trashtalk, string[] Insult, byte Hit)
        {
            this.name = Name;
            this.trashtalk = Trashtalk;
            this.insult = Insult;
            this.hit = Hit;      
        }
    }
    internal class Program
    {
        public static void square()
        {
            Console.WriteLine("task1");
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("x1=" + Convert.ToString((-b + Math.Sqrt(b * b - 4 * a * c)) / 2 / a) + " x2=" + Convert.ToString((-b - Math.Sqrt(b * b - 4 * a * c)) / 2 / a));
        }
        public static void random()
        {
            Random random = new Random();
            int[] array = new int[20];
            int[] array1 = new int[20];
            int i = 0;
            int j = 0;
            for (i = 0; i < 20; i++)
            {
                array[i] = random.Next(100);
            }
            for (i = 0; i < 19; i++)
            {
                for (j = 0; j < 20; j++)
                {

                    if ((i != j) && (array[i] == array[j]))
                    {
                        array[i] = random.Next(100);
                        i--;
                        break;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine("enter 2 numbers, that should be swapped");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (j = 0; j < 20; j++)
            {
                if (b == array[j])
                {
                    break;
                }
            }
            (array[i], array[j]) = (array[j], array[i]);
            Console.WriteLine(String.Join(" ", array));
        }
        //public static short hits(string[] args)
        //    {
        //    short hitcount = 0;
        //    string[] insult_list = {"blyat","suka","blya","" };
        //    foreach (string arg in args)
        //    {
        //        foreach (string arg1 in insult_list)
        //        {
        //            if (arg == arg1)
        //            {
        //                hitcount++;
        //            }
        //        }
        //    }
        //    }
        public static void sort()
        {
            Random random = new Random();
            int[] array = new int[20];
            int i= 0;
            int j = 0;
            for (i = 0; i < 20; i++)
            {
                array[i] = random.Next(100);
            }
            Console.WriteLine(String.Join(" ", array));
            for (i=19; i>=0; i--)
            {
                for (j = i; j < 19; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", array));
        }
        public static double[] array(int[] args)
        {
            double sum = 0.0;
            double proizv = 1;
            double num = 0.0;
            for (int i = 0; i<10; i++)
            {
                sum = sum + args[i];
                proizv = proizv * args[i];
                num++;
            }
            double[] awooga = new double[3];
            awooga[0] = Convert.ToDouble(sum);
            awooga[1] = Convert.ToDouble(proizv);
            awooga[2] = Convert.ToDouble(sum/num);
            return (awooga);
        }
        public static void risovashka()
        {
            Console.WriteLine("Enter number 0-9");
            var chislo = Console.ReadLine();
            try
            {
                while ((chislo != "exit") && (chislo != "закрыть"))
                {
                    int chislo1 = Convert.ToInt32(chislo);
                    switch (chislo1)
                    {
                        case 0:
                            Console.WriteLine("  ###  \n #   # \n#     #\n#     #\n #   #\n  ###  ");
                            break;
                        case 1:
                            Console.WriteLine("  #\n  #\n  #\n  #\n  #");
                            break;
                        case 2:
                            Console.WriteLine(" ### \n#   #\n    # \n   #  \n #   \n#####");
                            break;
                        case 3:
                            Console.WriteLine("#### \n    #\n#### \n    #\n####");
                            break;
                        case 4:
                            Console.WriteLine("#  # \n#  # \n#### \n   #\n   #");
                            break;
                        case 5:
                            Console.WriteLine("#####\n#\n####\n    #\n####");
                            break;
                        case 6:
                            Console.WriteLine(" ####\n#\n####\n#   #\n ###");
                            break;
                        case 7:
                            Console.WriteLine("#####\n    #\n   #\n  #\n #");
                            break;
                        case 8:
                            Console.WriteLine(" ###\n#   #\n ###\n#   #\n ###");
                            break;
                        case 9:
                            Console.WriteLine(" ###\n#   #\n ####\n    #\n ### ");
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Red;
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("ERROR");
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                    chislo = Console.ReadLine();

                }
            }
            catch (Exception)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                System.Threading.Thread.Sleep(3000);//зачем?
                Console.WriteLine("ERROR");
                Console.BackgroundColor = ConsoleColor.Black;
            }              
        }
        //public static void Ded(string[] args)
        //{
        //    short hit1 = 0;
        //    short hit2 = 0;
        //    short hit3 = 0;
        //    short hit4= 0;
        //    short hit5 = 0;
        //    string[] insult1 = new string[] { "sssss" };
        //    ded ded1 = ("Михалыч", 1, ("kozel","shit"), hits("kozel", "shit");
        //    ded ded2 = ("Ильич", 2, ("kozel", "shit","blyat"), hit2);
        //    ded ded3 = ("Горыныч", 3, ("kozel", "shit","suka","blyat"), hit3);
        //    ded ded4 = ("Максимыч", 5, ("kozel", "shit","fuck","blyat","suka"), hit4);
        //    ded ded5 = ("Кузьмич", 1, ("kozel"), hit5);
        //}
        static void Main(string[] args)
        {
            //square();
            //random();
            ////sort();
            //Random random = new Random();
            //int[] rray = new int[10];
            //for (int i = 0; i < 10; i++)
            //{

            //    rray[i] = random.Next(10);
            //}
            //Console.WriteLine(String.Join(" ", rray));
            //Console.WriteLine(String.Join(" ", array(rray)));
            risovashka();

        }

    }
}
