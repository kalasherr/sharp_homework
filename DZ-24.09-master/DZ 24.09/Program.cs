using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_24._09
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
    alkash stud1 = new alkash("Андрей", "Калашников", 1, "20.05.2005", "d", 0.1);
}
