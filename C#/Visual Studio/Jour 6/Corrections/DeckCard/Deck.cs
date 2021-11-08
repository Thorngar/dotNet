using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Card
{
    class Deck
    {
        private List<Card> CardList;       

        public Deck()
        {
            CardList = new List<Card>();
        }

        public void AddCard(Card c)
        {
            CardList.Add(c);
        }

        public void GiveCards(Deck ToDeck, int numberOfCards)
        {
            Random random = new Random();

            for(int i = 0; i< numberOfCards; i++)
            {
                int pickNumber = random.Next(0, this.CardList.Count - 1);

                if (CardList[pickNumber] != null)
                {
                    ToDeck.AddCard(CardList[pickNumber]);
                    this.CardList.RemoveAt(pickNumber);
                }
            }           
        }

        public override string ToString()
        {
            string tempCardList = "";
            foreach(Card c in CardList)
            {
                tempCardList += c.ToString() + "\n";
            }
            return tempCardList;
        }
    }
}
