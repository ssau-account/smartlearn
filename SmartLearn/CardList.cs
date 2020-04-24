using System;
using System.Collections.Generic;

namespace SmartLearn
{
    class CardList
    {
        public List<Card> Cards { get; private set; }
        public int current;
        public string Name;
        Random rand = new Random();

        public CardList(string Name)
        {
            Cards = new List<Card>();
            current = 0;
            this.Name = Name;
        }

        public void Add(Card card)
        {
            Cards.Add(card);
        }

        public Card GetNext()
        {
            Card c = Cards[current];
            if (current < Cards.Count - 1) current++;
            return c;
        }

        public Card GetPrev()
        {
            current -= 2;
            Card c = GetNext();
            return c;
        }
        
        public Card GetNextRandom()
        {
            int i = rand.Next() % Cards.Count;
            return Cards[i];
        }

        public bool IsStart(Card card)
        {
            return (Cards.IndexOf(card) == 0);
        }

        public bool IsLast(Card card)
        {
            return (Cards.IndexOf(card) == Cards.Count-1);
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
