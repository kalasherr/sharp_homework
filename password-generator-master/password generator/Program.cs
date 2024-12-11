using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace password_generator
{

    internal static class Program
    {
        public static (Dictionary<int, string>,int) Add(List<string> list,int a, Dictionary<int, string> dict)
        {
            foreach (var b in list)
            {
                dict.Add(a, b);
                a++;
            }
            return (dict,a);
        }

        public static string Generate(Dictionary<int,string> b,int c)
        {
            
            string a = string.Empty;
            return a;
        }
        [STAThread]
        static void Main()
        {
            
            
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new generator());
        }
    }
}
