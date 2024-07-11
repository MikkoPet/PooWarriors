using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Guerrier
    {
        #region attributes
        private string  _name;
        private int     _health;
        private int     _diceAmt;
        #endregion

        public static int turns = 0;

        #region properties
        public string Name { get => _name; set => _name = value == String.Empty ? "Warrior" : value; }
        public int Health { get => _health; set => _health = value; }
        public int DiceAmt { get => _diceAmt; set => _diceAmt = value; }

        #endregion

        public virtual int TurnDamage()
        {
            turns++;
            int damage = new Random().Next(1 * DiceAmt, 6 * DiceAmt);
            Console.WriteLine($"{Name} attacks for {damage} damage.");
            return damage;
        }

        public virtual void OuchOuch(int damage)
        {
            Health = Health < damage ? Health = 0 : Health -= damage;
            Console.WriteLine($"{Name}'s health is reduced to {Health}.");
        }

        public Guerrier(string newName, int newHealth, int newDiceAmt)
        {
            Name = newName;
            Health = newHealth;
            DiceAmt = newDiceAmt;
        }

    }
}
