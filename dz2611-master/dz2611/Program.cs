using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace dz2611
{
    internal class Program
    {
        public static List<int> RandomGames()
        {
            Random rndgame = new Random();
            int index;
            Dictionary<int,int>  gamelist = new Dictionary<int, int>();
            int count = 1;
            gamelist.Add(1, 2);
            gamelist.Add(2, 3);
            gamelist.Add(3, 5);
            gamelist.Add(4, 7);
            gamelist.Add(5, 11);
            gamelist.Add(6, 13);
            List<int> playlist = new List<int>();
            while (count<2*3*5*7*11*13)
            {
            
                index = rndgame.Next(6)+1;
                if (count % gamelist[index] != 0) 
                {   
                    playlist.Add(index);
                    count = count * gamelist[index];
                    playlist.Add(index);
                    //Console.WriteLine(count);
                }
            }
            return playlist;
            
        }

        static void Main(string[] args)
        {
            
            
            Dictionary<string, int> russiateam = new Dictionary<string,int>();
            russiateam.Add("Ioann",0);
            russiateam.Add("Andrey",0);
            russiateam.Add("Kuzma", 0);
            russiateam.Add("Maria", 0);
            russiateam.Add("Mihail", 0);
            russiateam.Add("Evgeniy", 0);
            russiateam.Add("Svyatoslav", 0);
            russiateam.Add("Svyatozar", 0);
            russiateam.Add("Ilya", 0);
            russiateam.Add("Dobrynya", 0);
            russiateam.Add("Nikolay", 0);
            russiateam.Add("Grioriy", 0);
            russiateam.Add("Gorynich", 0);
            russiateam.Add("Baba Yaga", 0);
            russiateam.Add("Koshey",0);
            Team russia = new Team(Countries.Russia,russiateam);
            Dictionary<string, int> chinateam = new Dictionary<string, int>();
            chinateam.Add("Hu Tao",0);
            chinateam.Add("Gan Yu", 0);
            chinateam.Add("Ke Quin",0);
            chinateam.Add("Zhong Li", 0);
            chinateam.Add("Fu Ji", 0);
            chinateam.Add("Bai Hu", 0);
            chinateam.Add("Li Zin", 0);
            chinateam.Add("Hu Li", 0);
            chinateam.Add("Du Du", 0);
            chinateam.Add("Dai Bu", 0);
            chinateam.Add("Ku Zin", 0);
            chinateam.Add("Ching Chong", 0);
            chinateam.Add("Ma Long", 0);
            chinateam.Add("Mei Zin", 0);
            chinateam.Add("Xiao Bai", 0);
            chinateam.Add("Chin Chopa", 0);
            Team china = new Team(Countries.China, chinateam);
            Dictionary<string, int> ukraineteam = new Dictionary<string, int>();
            chinateam.Add("Ivan1", 0);
            chinateam.Add("Ivan2", 0);
            chinateam.Add("Ivan3", 0);
            chinateam.Add("Ivan Grozniy", 0);
            chinateam.Add("Yarik", 0);
            chinateam.Add("Zelenskiy", 0);
            chinateam.Add("Poroshenko", 0);
            chinateam.Add("EeOneGuy", 0);
            chinateam.Add("Vilat", 0);
            chinateam.Add("Dendi", 0);
            chinateam.Add("Mihailo", 0);
            chinateam.Add("Alohadance", 0);
            chinateam.Add("zxcursed", 0);
            chinateam.Add("Klichko1", 0);
            chinateam.Add("Klichko2", 0);
            chinateam.Add("Hohol", 0);
            Team ukraine = new Team(Countries.Ukraine, ukraineteam);
            Dictionary<string, int> franceteam = new Dictionary<string, int>();
            franceteam.Add("ZywOo",0);
            franceteam.Add("Macron", 0);
            franceteam.Add("Lyagushka", 0);
            franceteam.Add("Ulitka", 0);
            franceteam.Add("Napoleon", 0);
            franceteam.Add("Pascal", 0);
            franceteam.Add("Joan of Arc", 0);
            franceteam.Add("Jules Verne", 0);
            franceteam.Add("Mbappe", 0);
            franceteam.Add("Lui Paster", 0);
            franceteam.Add("Alexandre Dumas", 0);
            franceteam.Add("D'Artanian", 0);
            franceteam.Add("Victor Hugo", 0);
            franceteam.Add("Baget", 0);
            franceteam.Add("Francuz", 0);
            List<string> games = new List<string>();
            foreach (int count in RandomGames())
            {
                switch (count)
                {
                    case 0:
                        games.Add("beach");
                        break;
                    case 1:
                        games.Add("mousetrap");
                        break;
                    case 2:
                        games.Add("sea");
                        break;
                    case 3:
                        games.Add("fishing");
                        break;
                    case 4:
                        games.Add("postman");
                        break;
                    case 5:
                        games.Add("slide");
                        break;
                }
            }
            Random points = new Random();
            int russum = 0;
            int chsum = 0;
            int ukrsum = 0;
            int frsum = 0;
            int playerpoints = 0;
            int winnersum = 0;
            string winner = "";
            foreach (var game in games)
            {
                Console.WriteLine("Now teams will play " + game);
                Console.WriteLine("Russia team roster:");
                foreach (var player in russiateam)
                {
                    playerpoints = points.Next(100);
                    Console.WriteLine(player.Key + " " + playerpoints);
                    russum = russum + playerpoints;
                    if (russum>winnersum)
                    {
                        winner = "Russia";
                        winnersum = russum;
                    }
                }
                Console.WriteLine("China team roster:");
                foreach (var player in chinateam)
                {
                    playerpoints = points.Next(100);
                    Console.WriteLine(player.Key + " " + playerpoints);
                    chsum = chsum + playerpoints;
                    if (chsum>winnersum)
                    {
                        winner = "China";
                        winnersum = chsum;
                    }
                }
                Console.WriteLine("Ukraine team roster:");
                foreach (var player in ukraineteam)
                {
                    playerpoints = points.Next(100);
                    Console.WriteLine(player.Key + " " + playerpoints);
                    ukrsum = ukrsum + playerpoints;
                    if (ukrsum>winnersum)
                    {
                        winnersum = ukrsum;
                        winner = "Ukraine";
                    }
                }
                Console.WriteLine("France team roster:");
                foreach (var player in franceteam)
                {
                    playerpoints = points.Next(100);
                    Console.WriteLine(player.Key + " " + playerpoints);
                    frsum = frsum + playerpoints;
                    if (frsum>winnersum)
                    {
                        winnersum = frsum;
                        winner = "France";
                    }
                }
                Console.WriteLine("Winner is " + winner);
            }
            
        }
        
    }
}
