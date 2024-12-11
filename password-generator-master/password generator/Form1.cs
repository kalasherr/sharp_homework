using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class generator : Form
    {

        int a = 0;
        Dictionary<int, string> symbols = new Dictionary<int, string>();
        List<string> lower = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        List<string> upper = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        List<string> digits = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        List<string> fuck = new List<string>() { "#", "!", "$", ";", "_","-",":","+","/", "&", "^", "%", "&", "*", "(", ")", "{", "}", "[", "]" };
        public static (Dictionary<int, string>, int) Add(List<string> list, int a, Dictionary<int, string> dict)
        {
            foreach (var b in list)
            {
                dict.Add(a, b);
                a++;
            }
            return (dict, a);
        }
        public generator()
        {
            InitializeComponent();
            a = (Add(lower, a, symbols).Item2);
        }
        
        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                a = Add(digits, a, symbols).Item2;
                
            }
            checkBox3.Enabled = false;
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                a = Add(upper, a, symbols).Item2;

            }
            checkBox2.Enabled = false;
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                a = Add(fuck, a, symbols).Item2;

            }
            checkBox1.Enabled = false;

        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            int b = Convert.ToInt32(numericUpDown1.Value);
            Random random = new Random();
            int r = 0;
            string password = "";
            for (int i = 0; i < b; i++)
            {
                r = random.Next(0, a);
                password = password + symbols[r];
            }
            label3.Text = password;
            //foreach (var c in symbols)
            //{
            //    Console.WriteLine(b);
            //}

            
        }
    }
}
