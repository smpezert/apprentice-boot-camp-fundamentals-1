namespace McrDigital.Bootcamp1.Cards
{
    using System;

    public class Snap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose the game you want to play of the list:\nAnimal\nSuits\nMixed");
            var usersInput = Console.ReadLine();


            var snap = ChooseGame(usersInput);
                
            snap.Play();
        }

        private static Snap ChooseGame(string usersInput)
        {
            Snap snap;
            switch (usersInput)
            {
                case "Animal":
                    snap = new Snap(new AnimalDeck());
                    break;
                case "Suits":
                    snap = new Snap(new PlayingCardDeck());
                    break;
                case "Mixed":
                    snap = new Snap(new MixedDeck());
                    break;
                default:
                    snap = new Snap(new MixedDeck());
                    break;
            }

            return snap;
        }

        private int _player1Score;
        private int _player2Score;
        private readonly Deck _deck;

        public Snap(Deck deck)
        {
            _deck = deck;
            _deck.Shuffle();
        }

        public void Play()
        {
            Card previousCard = null;
            while (_deck.GetCards().Length > 0)
            {
                var currentCard = _deck.Deal();
                Console.WriteLine(currentCard);

                var input = Console.ReadLine();
                if (input.Length > 0 && input[0] == 'a')
                {
                    if (currentCard.Snap(previousCard))
                    {
                        Console.WriteLine("SNAP! score Player 1");
                        _player1Score++;
                    }
                    else
                    {
                        Console.WriteLine("WRONG! deducting score from Player 1");
                        _player1Score--;
                    }
                }
                else if (input.Length > 0 && input[0] == 'l')
                {
                    if (currentCard.Snap(previousCard))
                    {
                        Console.WriteLine("SNAP! score Player 2");
                        _player2Score++;
                    }
                    else
                    {
                        Console.WriteLine("WRONG! deducting score from Player 2");
                        _player2Score--;
                    }
                }

                previousCard = currentCard;
            }

            if (_player1Score == _player2Score)
            {
                Console.WriteLine("Draw.");
            }
            else if (_player1Score > _player2Score)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }

            Console.WriteLine($"Scores: {_player1Score} vs {_player2Score}");

            //Just wait for input before closing console
            Console.ReadLine();
        }
    }
}