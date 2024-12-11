using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace dz2611
{
    public interface IGame
    {
        void Play();
    }
    internal class Game
    {
        public int gameid;
    }
    class Beach:Game,IGame
    {
        const string gamename = "beach";
        public Beach (int gameid)
        {
            this.gameid = gameid;
        }
        public void Play() { }
    }
    class Mousetrap : Game, IGame
    {
        const string gamename = "mousetrap";
        public Mousetrap(int gameid)
        {
            this.gameid = gameid;
        }
        public void Play() { }
    }
    class Sea : Game, IGame
    {
        const string gamename = "sea";
        public Sea(int gameid)
        {
            this.gameid = gameid;
        }
        public void Play() { }
    }
    class Fishing:Game, IGame
    {
        const string gamename = "fishing"; 
        public Fishing(int gameid)
        {
            this.gameid = gameid;
        }
        public void Play() { }
    }
    class Postman:Game, IGame
    {
        const string gamename = "postman";
        public Postman(int gameid)
        {
            this.gameid = gameid;
        }
        public void Play() { }
    }
    class Slide : Game, IGame
    {
        const string gamename = "slide";
        public Slide(int gameid)
        {
            this.gameid = gameid;
        }
        public void Play() { }
    }
}
