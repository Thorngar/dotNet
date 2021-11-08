using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Card
{
    class Card
    {
        private int Numero;
        private CardFamiliesEnum CardFamiliesEnum;
        private CardColor CardColor;

        public Card(int numero, CardFamiliesEnum cardFamiliesEnum)
        {
            this.Numero = numero;
            this.CardFamiliesEnum = cardFamiliesEnum;
            switch (cardFamiliesEnum)
            {
                case CardFamiliesEnum.Trefle:
                    this.CardColor = CardColor.Noire;
                    break;
                case CardFamiliesEnum.Carreau:
                    this.CardColor = CardColor.Rouge;
                    break;
                case CardFamiliesEnum.Coeur:
                    this.CardColor = CardColor.Rouge;
                    break;
                case CardFamiliesEnum.Pique:
                    this.CardColor = CardColor.Noire;
                    break;
            }
        }

        public override string ToString()
        {
            return this.Numero + " " + this.CardFamiliesEnum + " " + this.CardColor;
        }

    }
}
