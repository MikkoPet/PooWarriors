using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Nain : Guerrier
    {

        private int _armour;

        public int Armour {  get => _armour ; set => _armour = value ; }

        public Nain(string newName, int newHealth, int newDiceAmt, int newArmour) 
            : base (newName, newHealth, newDiceAmt)
        {
            Armour = newArmour ;
        }
    }
}
