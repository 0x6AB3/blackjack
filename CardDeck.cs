using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    public class CardDeck
    {
        public readonly string[] cardRanks = new string[]{ "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public readonly string[] cardSuits = new string[] { "Hearts", "Diamonds", "Spades", "Clubs" };
        private List<Card> _cards = new List<Card>();
        
        public CardDeck()
        {
            foreach (var rank in cardRanks)
            {
                foreach (var suit in cardSuits)
                {
                    var card = new Card(rank, suit);
                    _cards.Add(card);
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            for (var i = 0; i < 10000; i++)
            {
                var card1Index = RandomNumberGenerator.GetInt32(0, _cards.Count);
                var card2Index = RandomNumberGenerator.GetInt32(0, _cards.Count);
                var card1 = _cards[card1Index];
                var card2 = _cards[card2Index];
                _cards[card1Index] = card2;
                _cards[card2Index] = card1;
            }
        }
    }
}
