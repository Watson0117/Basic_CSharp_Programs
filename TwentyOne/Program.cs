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
           

            Deck deck = new Deck();//this instanciates the deck object
            //deck.Shuffle(3);//this calls the shuffle method on the deck object

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
                //above goes through the list of cards and prints each one to the console
            }
            Console.WriteLine("Number of cards in deck: {0}", deck.Cards.Count);// this calles the property count that is built into list
            Console.ReadLine();
        }

        //Game game = new TwentyOneGame();// this line demonstrates Polymorphisim. we craet a game object but call the TwentyOneGame object.


        //TwentyOneGame game = new TwentyOneGame();//TwentyOne Game inherits from the game class
        //game.Players = new List<string>() { "Vlad", "Greg", "Ron" };
        //game.ListPlayers();//In these two lines we are calling a superclass with game. 
        ////game.Play(); //The Play method is uniqe to the TwentyOneGame method and if we changer the Line above to game instedad of TwentyOneGame it would be inaccessable
        //Console.ReadLine();// We dident have to instanciat the game class because it was inherited by the TwentyOneGame class




        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

    }
}
