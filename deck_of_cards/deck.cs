// Give the Deck class a property called "cards" which is a list of Card objects
// When initializing the deck make sure that it has a list of 52 unique cards as its "cards" property
// Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card
// Give the Deck a reset method that resets the cards property to the contain the original 52 cards
// Give the Deck a shuffle method that randomly reorders the deck's cards
using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Deck {
        public List<Card> cards;

        public Deck() {
            reset();
        }

        public Card deal() {
            if (cards.Count > 0) {
                Card removed = cards[0];
                cards.RemoveAt(0);
                return removed;
            }
            return null;
        }

        public Deck reset() {
            cards = new List<Card>();
            string[] suits = new string[4] {"spades", "hearts", "diamonds", "clubs"};
            foreach (string suit in suits) {
                for(int i = 1; i <= 13; i++) {
                    cards.Add(new Card(suit, i));
                }
            }
            return this;
        }

        public Deck shuffle() {
            Random rand = new Random();
            for(int i = cards.Count - 1; i > 0; i--) {
                int randidx = rand.Next(i);
                Card temp = cards[randidx];
                cards[randidx] = cards[i];
                cards[i] = temp;
            }
            return this;
        }

        public override string ToString() {
            string info = "";
            foreach(Card card in cards) {
                info += card + "\n";
            }
            return info;
        }
    }
} 