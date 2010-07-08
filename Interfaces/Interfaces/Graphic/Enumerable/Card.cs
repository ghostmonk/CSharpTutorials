using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Interfaces.Enumerable
{
    class Card
    {
        private CardSuit _suit;
        private int _value;

        public Card(CardSuit suit, int value)
        {
            _suit = suit;
            _value = value;
        }

        public CardSuit suit
        {
            get { return _suit; }
        }

        public int Value
        {
            get { return _value; }
        }

        public void Display()
        {
            Console.WriteLine( "Suit: {0}, value: {1}", _suit, _value );
        }
    }

    enum CardSuit {
        Heart, Diamond, Spade, Club
    }
}
