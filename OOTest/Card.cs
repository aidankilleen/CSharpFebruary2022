using System;
using System.Collections.Generic;
using System.Text;

namespace OOTest
{
    class Card
    {
        // member variables / field / properties
        private int suit; // 1 = H, 2 = S, 3 = D, 4 = C
        private int value; // 1 = A, 2 = 2, 3 = 3, ..., 11 = J, 12 = Q, 13 = K

        // member functions / methods

        // constructor(s)
        public Card()
        {
            suit = 1;
            value = 1;
        }

        public Card(int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        // other functions / methods
        public void Display()
        {
            string card = "";

            switch(value)
            {
                case 1:
                    card = " A";
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    card = " " + value;
                    break;
                case 10:
                    card = "" + value;
                    break;
                case 11:
                    card = " J";
                    break;
                case 12:
                    card = " Q";
                    break;
                case 13:
                    card = " K";
                    break;
                default:
                    card = " ?";
                    break;
            }

            if (suit == 1)
            {
                card = card + "H ";
            } else if (suit ==2)
            {
                card += "S ";
            } else if (suit == 3)
            {
                card += "D ";
            } else if (suit == 4)
            {
                card += "C ";
            } else
            {
                card += "? ";
            }

            Console.Write(card);

        }
    }
}
