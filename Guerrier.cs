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
        private int     _armour = 0;
        #endregion

        public static int turns = 0;

        #region properties
        public string Name { get => _name; set => _name = value == String.Empty ? "Warrior" : value; }
        public int Health { get => _health; set => _health = value; }
        public int DiceAmt { get => _diceAmt; set => _diceAmt = value; }
        public int Armour { get => _armour; }

        #endregion

        public virtual int TurnDamage()
        {
            turns++;
            int damage = new Random().Next(1 * DiceAmt, 6 * DiceAmt);
            return damage;
        }

        public Guerrier(string newName, int newHealth, int newDiceAmt)
        {
            Name = newName;
            Health = newHealth;
            DiceAmt = newDiceAmt;
        }

    }
}
