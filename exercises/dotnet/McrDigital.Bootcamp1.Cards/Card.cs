using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McrDigital.Bootcamp1.Cards
{
    public abstract class Card
    {
        public abstract string Value { get; }

        public bool Snap(Card other)
        {
            return Value == other.Value;
        }
    }
}
