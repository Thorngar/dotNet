using System;

namespace Deck_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck0 = new Deck();

            foreach(CardFamiliesEnum singleFamily in (CardFamiliesEnum[])CardFamiliesEnum.GetValues(typeof(CardFamiliesEnum)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    deck0.AddCard(new Card(i, singleFamily));
                }
            }

            Deck deck1 = new Deck();

            Deck deck2 = new Deck();

            deck0.GiveCards(deck1, 5);
            deck0.GiveCards(deck2, 5);


            Console.WriteLine(deck0.ToString());
            Console.WriteLine("===============");
            Console.WriteLine(deck1.ToString());
            Console.WriteLine("===============");
            Console.WriteLine(deck2.ToString());





        }
    }
}
