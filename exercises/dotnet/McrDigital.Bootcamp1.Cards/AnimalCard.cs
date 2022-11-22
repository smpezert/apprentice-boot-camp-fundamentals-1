namespace McrDigital.Bootcamp1.Cards
{
    public class AnimalCard : ICard
    {
        private readonly Animal _animal;

        public AnimalCard(Animal animal)
        {
            _animal = animal;
        }

        public Animal Animal
        {
            get => _animal;
        }
        string ICard.Value 
        { 
            get => _animal.ToString();
        }

        public bool Snap(ICard other)
        {
            return _animal.ToString() == other.Value;
        }

        public override string ToString()
        {
            return _animal.ToString();
        }
    }
}