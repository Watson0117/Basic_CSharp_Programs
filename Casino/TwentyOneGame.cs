using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame: Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(3);

            Console.WriteLine("Place your bets!");

            foreach (Player player in Players)
            {
                
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);// if the player bets it will set successfullyBet to true
                if (!successfullyBet)// !successfullyBet means the same as successfullyBet = false
                {
                    return;
                }
                Bets[player] = bet;//Bets is the dic player is the key and ther bet is the bet that gets added to the dic
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing");
                foreach (Player player in Players)
                {
                   
                    Console.Write("{0}:", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i > 0)// if the player gets another card check for blackjack
                    {
                        bool blackjack = TwentyOneRules.CheckForBackJack(player.Hand);
                        if (blackjack)
                        {
                          
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);// adds 1.5 times the players bet inital bet plus that players inital bet back to balance
                            Console.WriteLine("Play Again?");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                            {
                                player.isActivelyPlaying = true;
                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                            }
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i >= 1)//if (i == 1) checks if the dealer has 2 cards if so it checks for blackjack
                {
                    bool blackjack = TwentyOneRules.CheckForBackJack(Dealer.Hand);// checks the dealers hand for blackjack
                    if (blackjack)// if the dealer has blackjack do the following
                    {

                        Console.WriteLine("Dealer has blackjack so sorry for you");
                        foreach (KeyValuePair<Player, int> entry in Bets)// if dealer blackjack it takes each players bet of all keyvaluepairs in Bets array
                        {
                            Dealer.Balance += entry.Value;// adds players bets to the dealers Balance
                        }
                        foreach (Player player in Players)
                        {
                            Console.WriteLine("Play Again?");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                            {
                                player.isActivelyPlaying = true;
                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                            }

                        }


                    }
                }
            }

            foreach (Player player in Players)
            {
                
                
                while (!player.Stay)//(!player.Stay) same as (player.Stay == false), if player chooses not to stay do this
                {
                    Console.Write("\n\nDealers cards are: ");
                    foreach (Card card in Dealer.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    
                    Console.Write("\n\n{0}'s cards are: ", player.Name);
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }


                    int handValuesD = TwentyOneRules.HandValuesD(Dealer.Hand);
                    Console.Write(handValuesD);
                    int handValuesP = TwentyOneRules.HandValuesP(player.Hand);
                    Console.Write(handValuesP);
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;// if they stay ends the turn
                        break;
                    }
                    else if (answer == "hit")// if they hit do this
                    {
                        Dealer.Deal(player.Hand);//deals the player another card
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);// checks if the palyuer busted

                    if (busted && player.Balance == 0)
                    {
                        Dealer.Balance += Bets[player];// takes players bet and add it to dealers balance
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);

                        Console.WriteLine("Bad luck, thats the way it goes sometimes.");
                        player.isActivelyPlaying = false;// if the player says no then sets playe isActilyplaying to false stoping the play() method
                        return;
                    }
                    if (busted)// if they are busted do this
                    {
                       
                        Dealer.Balance += Bets[player];// takes players bet and add it to dealers balance
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                       
                        Console.WriteLine("Do you want to play agian?");
                        answer = Console.ReadLine().ToLower();// gets player response and makes all responses lower for redundancy
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" && player.Balance > 0)
                        {
                            player.isActivelyPlaying = true;// if yes sets playe as avtivly playing allowing new round to continue
                            return;
                        }
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" && player.Balance !>0)
                        {
                            Console.WriteLine("Sorry your out of money.");
                            player.isActivelyPlaying = false;// if the player says no then sets playe isActilyplaying to false stoping the play() method
                            return;
                        }
                        if (answer == "no" || answer == "n")
                        {
                            player.isActivelyPlaying = false;// if the player says no then sets playe isActilyplaying to false stoping the play() method
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;// if the player says no then sets playe isActilyplaying to false stoping the play() method
                            return;
                        }
                    }
                }
            }

            
            
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);// checks if dealer busts
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);// checks valus of dealer hand and determins stay or hit
            while (!Dealer.Stay && !Dealer.isBusted)// as long as dealer is not stayinf and is not busted do this
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);// adds card to dealer hand
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);// checks for bust after new card
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);// gets value of hand and determins if dealer shuld stay or hit
            }
            if (Dealer.Stay)
            {
               
                Console.WriteLine("Dealer is Staying");
                
            }
            if (Dealer.isBusted)
            {
                
                Console.WriteLine("Dealer Busted!!!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += entry.Value * 2;// give players there bet back plus how much the bet as winnings
                    foreach (Player player in Players)
                    {
                       
                        Console.WriteLine("{0} won {1}!  your Balance is now {2}", entry.Key.Name, entry.Value, entry.Key.Balance);
                        Dealer.Balance -= entry.Value;// if the dealer bust all players win
                    }
                    
                }
                foreach (Player player in Players)
                {
                    Console.WriteLine("Play Again?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                    {
                        player.isActivelyPlaying = true;
                    }
                    else
                    {
                        player.isActivelyPlaying = false;
                    }
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //bool/ allows a bool to have the value null
                if (playerWon == null)
                {
                   
                    Console.WriteLine("Push no one wins!!");
                    player.Balance += Bets[player];// if there is a push asin nobody wins then the player gets there bet back
                    
                    
                }
                else if (playerWon == true)
                {
                    
                    player.Balance += (Bets[player] * 2);// if the player wins they get twice there bet back
                    Console.WriteLine("{0} won {1}! your Balance is now {2}", player.Name, Bets[player], player.Balance);
                    
                    Dealer.Balance -= Bets[player];// the dealer loses amount equal to th players bet
                    return;
                }
                else
                {
                    
                    Console.WriteLine("Dealer wins {0}! You balance is now {1} ", Bets[player], player.Balance);
                    Dealer.Balance += Bets[player];// if the dealer wins thet dealer takes the palyers bet 
                }
                Console.WriteLine("Play Again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
            
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
