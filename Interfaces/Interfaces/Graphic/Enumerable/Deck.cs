using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Interfaces.Interfaces.Enumerable
{
    class Deck : IEnumerable
    {
        private Card[] _cardDeck;

        public Deck()
        {
            _cardDeck = new Card[52];
            FillSuit(CardSuit.Club, 0);
            FillSuit(CardSuit.Diamond, 13);
            FillSuit(CardSuit.Heart, 26);
            FillSuit(CardSuit.Spade, 39);
        }

        private void FillSuit(CardSuit suit, int last)
        {
            for (int i = 0; i < 13; i++)
                _cardDeck[ last + i ] = new Card(suit, i + 1);
        }

        public IEnumerable GetClubs()
        {
            for (int i = 0; i < 13; i++)
                yield return _cardDeck[i];
        }

        public IEnumerator GetEnumerator()
        {
            yield return _cardDeck[0];
            yield return _cardDeck[1];
            yield return _cardDeck[2];
            yield return _cardDeck[3];
            yield return _cardDeck[4];
            yield return _cardDeck[5];
            yield return _cardDeck[6];
            yield return _cardDeck[7];
            //foreach (Card card in _cardDeck)
                //yield return card;
            //return _cardDeck.GetEnumerator();
        }
    }
}
