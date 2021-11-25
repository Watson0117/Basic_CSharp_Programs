using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck // Deck will be a collection of cards
    {
        public Deck()// this is a constructor
        {
            Cards = new List<Card>();//this instanciates the property cards as a empty list
            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }// the list of cards is a property of the class deck

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();//this creates a temporay list to put cards into
                Random random = new Random();//this calls the random function 

                while (Cards.Count > 0)//this loopes through the deck until its out of cards
                {
                    int randomIndex = random.Next(0, Cards.Count);//this gets a random index from 0 to 52
                    TempList.Add(Cards[randomIndex]);//this adds the cards to templis at a random index
                    Cards.RemoveAt(randomIndex);//this revoves the card from the list so it canot be pulled agian
                }
                Cards = TempList;//thsi takes the cards no in templist and assigns that valus to deck.Cards in there new random order
            }
            //return deck;//this returns the now randomized deck back to gthe program
        }
    }
}
