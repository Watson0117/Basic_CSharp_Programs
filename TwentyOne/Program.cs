using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome the the Bobop Hotel and Casino!!! Whats your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money do you intend to use today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")// this make the program more robust by accepting answer that mean yes but may not acculy say yes
            {
                Player player = new Player(playerName, bank);// this creats a new player and bank for that player
                Game game = new TwentyOneGame();
                game += player;//this add the player to the game
                player.isActivelyPlaying = true;//this sets the player to active
                while (player.isActivelyPlaying && player.Balance > 0)//this checks if the player is activlyplaying value changes or if there bank drops to 0
                {
                    game.Play();
                }
                if (player.Balance <= 0)
                {
                    Console.WriteLine("sorry but your out of money");
                }
                game -= player;//this removes the player from the game if the players is activlyplaying value changes or if there bank dropes to 0
                
                Console.WriteLine("Thank you for playing!");
            }
            //if the player answers no to the question do you want to play 21 
            //it will skipp the above loop and go here.
            Console.WriteLine("Feel free to look around the Bebop have a nice day!");
            Console.ReadLine();
        }

    }
}
