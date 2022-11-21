using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCard
    {
        public PlayingCard(Suit suit, int faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        }

        public Suit Suit {get; private set;}
        public int FaceValue {get; private set;}

        public override string ToString()
        {
            var facevaluename = string.Empty;

                switch (FaceValue)
                {
                    case 0:
                        facevaluename = "ace";
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        facevaluename = (FaceValue + 1).ToString();
                        break;
                    case 10:
                        facevaluename = "jack";
                        break;
                    case 11:
                        facevaluename = "queen";
                        break;
                    case 12:
                        facevaluename = "king";
                        break;
                    default: throw new ArgumentException($"something went wrong {FaceValue} is not a valid facevalue!");
                }

            return $"{facevaluename} of {Suit}";
        }
    }
}