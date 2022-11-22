namespace McrDigital.Bootcamp1.Cards
{
    using System;
    using System.Collections.Generic;

    public class AnimalDeck : Deck
    {

        public AnimalDeck()
        {
            Cards = new List<Card>();
            foreach (Animal animal in Enum.GetValues(typeof(Animal)))
            {
                Cards.Add(new AnimalCard(animal));
                Cards.Add(new AnimalCard(animal));
            }
        }
    }
}