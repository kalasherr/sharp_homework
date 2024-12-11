using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2611
{
    enum Countries
    {
        Russia,China,Ukraine,France
    }
    internal class Team
    {
        public Countries country;
        public Dictionary<string, int> names;
        public Team(Countries country, Dictionary<string, int> names)
        {
            this.country = country;
            this.names = names;
        }
    }
}
