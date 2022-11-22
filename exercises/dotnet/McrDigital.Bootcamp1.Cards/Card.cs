using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McrDigital.Bootcamp1.Cards
{
    public interface ICard
    {
        bool Snap(ICard other);

        public string Value { get; }

    }
}
