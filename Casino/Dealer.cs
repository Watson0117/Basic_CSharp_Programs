using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());// takes the first card in the deck and deals it to whoever is being delt to player or dealer
            string card = string.Format(Deck.Cards.First().ToString());// takes name of card and converts it to a string 
            Console.WriteLine(card);// 1 line down - creates a 21Logs.txt file and then appends it when ran again
            using (StreamWriter file = new StreamWriter(@"D:\Watson_Tech_Academy_repositories\Basic_CSharp_Programs\TwentyOne\logs\21Logs.txt", true))// by using using it cleans up memory after running
            {
                
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);// specifies what to writ ti the 21Logs file
            }
            Deck.Cards.RemoveAt(0);// removes the card from the decks list of cards. 
        }
    }
}
