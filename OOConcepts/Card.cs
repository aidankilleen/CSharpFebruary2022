using System;
using System.Collections.Generic;
using System.Text;

namespace OOConcepts
{

    enum Suits
    {
        Heart = 1, 
        Spade, 
        Diamond, 
        Club
    }

    enum Values
    {
        Ace = 1, 
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
        King
    }



    class Card
    {

        // C# Property
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        /*
        public Card()
        {
            Suit = Suits.Heart;
            Value = Values.Ace;
        }
        */


        // member functions / methods
        public Card(Suits suit = Suits.Heart, Values value = Values.Ace)
        {
            this.Suit = suit;
            this.Value = value;
        }

        // other functions / methods
        public void Display()
        {
            string card = "";

            switch (Value)
            {
                case Values.Ace:
                    card = " A";
                    break;
                case Values.Two:
                case Values.Three:
                case Values.Four:
                case Values.Five:
                case Values.Six:
                case Values.Seven:
                case Values.Eight:
                case Values.Nine:
                    card = " " + (int)Value;
                    break;
                case Values.Ten:
                    card = "" + (int)Value;
                    break;
                case Values.Jack:
                    card = " J";
                    break;
                case Values.Queen:
                    card = " Q";
                    break;
                case Values.King:
                    card = " K";
                    break;
                default:
                    card = " ?";
                    break;
            }

            if (Suit == Suits.Heart)
            {
                card = card + "H ";
            }
            else if (Suit == Suits.Spade)
            {
                card += "S ";
            }
            else if (Suit == Suits.Diamond)
            {
                card += "D ";
            }
            else if (Suit == Suits.Club)
            {
                card += "C ";
            }
            else
            {
                card += "? ";
            }

            Console.Write(card);

        }

    }
}
