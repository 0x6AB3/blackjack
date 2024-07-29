using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace blackjack
{
    class Card
    {
        public readonly string Rank;
        public readonly string Suit;

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public int Value()
        {
            if (int.TryParse(Rank, out var value))
            {
                return value;
            }

            if ("JQK".Contains(Rank))
            {
                return 10;
            }

            return 11;
        }
    }
}
