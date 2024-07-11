using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Elf : Guerrier
    {
        public override int TurnDamage()
        {
            turns++;
            int damage = new Random().Next(1 * DiceAmt, 6 * DiceAmt);
            Console.WriteLine($"{Name} attacks for {damage} damage.");
            return damage > 1 * DiceAmt ? damage : 2 * DiceAmt ;
        }
        // remove override and instead set a min and max attribute with default 1 & 6 that becomes 2 n 6 for elves

        public Elf(string newName, int newHealth, int newDiceAmt)
            : base(newName, newHealth, newDiceAmt)
        {        }
    }
}
