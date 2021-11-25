using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game//the game class is amade abstract so it can not be instanciated it can only be inherited from.
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

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
