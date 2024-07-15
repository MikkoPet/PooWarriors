using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Healer : Mage
    {
        public override int SendDamage()
        {
            int damage = new Random().Next(Min * DiceAmt, Max * DiceAmt);
            Console.WriteLine($"{Name} sends out a heal of {damage} heal.");
            Enmity += damage * EnmityMultiplier;
            hasAttacked = true;
            return damage;
        }
        public Healer(string newName, int newHealth, int newDiceAmt)
            : base(newName, newHealth, newDiceAmt)
        {
            EnmityMultiplier = 1;
        }
    }
}
