using System;
using System.Collections.Generic;
using System.Text;

namespace OOTest
{
    class Deck
    {
        // member variables / fields / properties
        private Card[] cards = new Card[52];
        private int currentCard = 0;

        // member functions / methods / functions
        // constructors(s)
        public Deck()
        {
            // instantiate 52 cards one for each suit / value combination
            int count = 0;
            for (int s = 1; s <= 4; s++)
            {
                for (int v = 1; v <= 13; v++)
                {
                    cards[count++] = new Card(s, v);
                }
            }
        }

        public Card Deal()
        {
            return cards[currentCard++];
        }

        // other methods
        public void Display()
        {
            for(int count=0; count < cards.Length; count++)
            {
                cards[count].Display();

                if (count == 12 || count == 25 || count == 38 || count == 51)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public void Shuffle(int count)
        {
            // mix up the cards
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                int r1 = rnd.Next(52);
                int r2 = rnd.Next(52);

                Card t = cards[r1];
                cards[r1] = cards[r2];
                cards[r2] = t;
            }
        }

        static void Main(string[] args)
        {
            // Code for testing a Deck
            Deck deck = new Deck();

            deck.Display();
            deck.Shuffle(1);
            deck.Display();  // is order of cards different???
            deck.Shuffle(10);
            deck.Display();  // is order of cards different???
            deck.Shuffle(100);
            deck.Display();  // is order of cards different???
            deck.Shuffle(10000000);
            deck.Display();  // is order of cards different???

            Card nextCard = deck.Deal();
            nextCard.Display();

            nextCard = deck.Deal();
            nextCard.Display();
        }
    }
}
