using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Mage : Fighter
    {
        public Mage(string newName, int newHealth, int newDiceAmt)
    : base(newName, newHealth, newDiceAmt)
        {
            _speed = 1;
        }
    }
}
