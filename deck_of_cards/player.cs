// Give the Player class a name property
// Give the Player a hand property that is a List of type Card
// Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card
// Note this method will require reference to a deck object
// Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Player {
        
        public string name;
        public List<Card> hand;

        public Player(string n) {
            hand = new List<Card>();
            name = n;
        }

        public Card draw(Deck d) {
            Card drawn = d.deal();
            if (drawn != null) {
                hand.Add(drawn);
                return drawn;
            }
            return null;
        }

        public Card discard(int idx) {
            if (idx <= hand.Count) {
                Card temp = hand[idx];
                hand.RemoveAt(idx);
                return temp;
            }
            return null;
        }

        public override string ToString() {
            string info = name + "'s hand:\n";
            foreach (Card card in hand) {
                info += card + "\n";
            }
            return info;
        }
    }
}