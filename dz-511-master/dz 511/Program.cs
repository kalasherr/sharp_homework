using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace dz_511
{
    public struct employer
    {
        public string name;
        public List<string> names;
        public employer(string name, List<string> names)
        {
            this.name = name;
            this.names = names; 
        }
    }
    
    
    internal class Program
    {
        public static void Work(List<employer> workers, string name1, string name2)
        {
            bool work_accept = false;
            foreach (var worker in workers)
            {
                if (worker.name ==  name1)
                {
                    foreach (var worker1 in worker.names)
                    {
                        if (worker1 == name2)
                        {
                            work_accept = true;
                        }
                    }
                }
            }
            if (work_accept)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        
        public static void Main()
        {
            List<string> w1 = new List<string> { "Rashid", "Ilham" };
            List<string> w2 = new List<string> { "Lukas" };
            List<string> w3 = new List<string> { "Orkadiy" };
            List<string> w4 = new List<string> { "Ilshat", "Sergey", "Ilshat" };
            List<string> w5 = new List<string> { "Ivanych", "Ilya", "Vitya", "Zhenya" };
            List<string> w6 = new List<string> { "Ilya", "Vitya", "Zhenya" };
            List<string> w7 = new List<string> { "Lyaisan", "Marat", "Dina", "Ildar", "Anton" };
            List<string> w8 = new List<string> { "Marat", "Dina", "Ildar", "Anton" };
            List<string> w9 = new List<string> { };
            List<string> w10 = new List<string> { "Sergey", "Ilshat"};

            employer Boris = new employer("Boris",w1);
            employer Rashid = new employer("Rashid", w2);
            employer Ilham = new employer("Ilham", w3);
            employer Orkadiy = new employer("Volodya", w4);
            employer Ilshat = new employer("Ilshats", w5);
            employer Ivanych = new employer("Ivanych", w6);
            employer Sergey = new employer("Sergey", w1);
            employer Lyaisan = new employer("Lyaisan", w7);
            employer Ilya = new employer("Ilya", w8);
            employer Vitya = new employer("Vitya", w9);
            employer Zhenya = new employer("Zhenya", w9);
            employer Marat = new employer("Marat", w9);
            employer Dina = new employer("Dina", w9);
            employer Ildar = new employer("Ildar",w9);
            employer Anton = new employer("Anton", w9);
            employer Volodya = new employer("Volodya", w10);
            List<employer> employers = new List<employer> {Boris,Rashid,Ilham,Orkadiy,Ilshat,Ivanych,Sergey,Lyaisan,Ilya,Vitya,Zhenya,Marat,Dina,Ildar,Anton,Volodya };
            Console.WriteLine("Enter commander name");
            string commander = Console.ReadLine();
            Console.WriteLine("Enter problem");
            Console.ReadLine();
            Console.WriteLine("Enter worker name");
            string worker_name = Console.ReadLine();
            Work(employers, commander, worker_name);
        }       
    }
}
