using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game//the game class is amade abstract so it can not be instanciated it can only be inherited from.
    {
        private List<Player> _players = new List<Player>();// this makes sure that there is always a empty list of players to start with 
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }   // creates a dict that holds the players bets

        public abstract void Play();// this is an abstract method. it make it so any class inheriting the game class will have to have a play method.

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)// for each string player in the list player it will print to the console
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
