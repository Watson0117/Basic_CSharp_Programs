using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);// checks each card in players hand to count aces
            int[] result = new int[aceCount + 1];//creates an array of how many aces are in hand
            int value = Hand.Sum(x => _cardValues[x.Face]);// uses the value 1 from the card dic in the sum. 11 will be a different method
            result[0] = value;
            if (result.Length == 1)
            {
                return result;//if there are no aces there can be only one results. also the return results at the end could go under in {} but it is short enugh to be on one line
            }
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);//"value += (i * 10)' is the sam as "value = value + (i * 10)" this gets the value and adds 10 to it
                result[i] = value;//
            }
            return result;
        }   

        public static bool CheckForBackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();// gets the maximum possible value of the players hand
            if (value == 21) return true;//if blackjack sets true
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();// gets value of players hand
            if (value > 21) return true;// checks if it is greater that 21 returns true if true
            else return false;// false if false
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possiblehandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possiblehandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;

        }
    }
}
