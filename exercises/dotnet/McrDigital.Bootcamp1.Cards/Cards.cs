namespace McrDigital.Bootcamp1.Cards
{
    using System;
    using System.Collections.Generic;

    public class Cards
    {
        static void Main(string[] args)
        {
            var encapsulation = new Cards();
            var deckInOrder = encapsulation.GetCards();
            foreach (var card in deckInOrder)
            {
                Console.WriteLine(card);
            }
        }

        public List<PlayingCard> GetCards()
        {
            var cards = new List<PlayingCard>();
            var deck = new int[52][];

            var suits = Enum.GetValues<Suit>();

            foreach (var suit in suits)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    //deck[suit * 13 + faceValue] = new int[] {suit, faceValue};
                    var card = new PlayingCard{ Suit = suit, FaceValue = faceValue};
                    cards.Add(card);
                }
            }

          

            return cards;
        }
    }
}