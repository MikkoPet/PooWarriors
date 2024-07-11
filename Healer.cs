using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Healer : Mage
    {
        public Healer(string newName, int newHealth, int newDiceAmt)
            : base(newName, newHealth, newDiceAmt)
        {        }
    }
}
