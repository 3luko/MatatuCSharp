using System;
using System.Runtime.CompilerServices;

namespace MatatuCSharp{

    public class Deck{
        private List<Card> cards; //using a list to better manipulate the deck of cards
        //Constructor method that initializes each 
        //card in the deck, it is initially in a
        //specific order.
        public Deck(){
            cards = new List<Card>();
            for(int i = 0; i < 4; i++){
                for(int j = 1; j <= 13; j++){
                    cards.Add(new Card((Suit)i, (Value)j));
                }
            }
        }
        //getter method to see the cards in the list
        public List<Card> Cards{
            get{
                return cards;
            }
        }
        //method to shuffle the deck
        //doesn't matter the size of the deck it still shuffles
        //regardless.
        public void shuffleDeck(){  //method for shuffling
            Random rand = new Random();
            for(int i = cards.Count - 1; i > 0; --i){
                int randIdx = rand.Next(0, i + 1);
                Card temp = cards[i];
                cards[i] = cards[randIdx];
                cards[randIdx] = temp;
            } 
        }
    }
}