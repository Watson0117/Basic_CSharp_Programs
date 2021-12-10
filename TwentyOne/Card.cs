using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{   //A class is a design or model of an object. like the plans on how to make it.
    public class Card// the card class is set to public so it can be used by other parts of the program
    {
        
        public Suit Suit { get; set; }//Suit is a property of the class "Card" It is set to public to allow it to be accessed by othor parts of the program.
        public Face Face { get; set; }//Face is the secodn property of the card class and is set to public

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King, 
        Ace
    }
}
