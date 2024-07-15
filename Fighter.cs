using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Fighter
    {
        #region attributes
        private string  _name;
        private int     _health;
        private int     _diceAmt;
        private int     _minAttackPotency;
        private int     _maxAttackPotency;
        private bool    _isAlive;
        private int     _enmity;
        private int     _enmityMultiplier;
        #endregion


        #region properties
        public string Name { get => _name; set => _name = value == String.Empty ? "Warrior" : value; }
        public int Health { get => _health; set => _health = value; }
        protected int DiceAmt { get => _diceAmt; set => _diceAmt = value; }
        protected int Min { get => _minAttackPotency; set => _minAttackPotency = value; }
        protected int Max { get => _maxAttackPotency; set => _maxAttackPotency = value; }
        protected bool IsAlive { get => _isAlive; set => _isAlive = value; }
        public int Enmity { get => _enmity; set => _enmity = value; }
        public int EnmityMultiplier { get => _enmityMultiplier; set => _enmityMultiplier = value; }
        #endregion


        public static int turns = 1;
        public static bool hasAttacked = false;
         

        public virtual int SendDamage()
        {
            int damage = new Random().Next(Min * DiceAmt, Max * DiceAmt);
            Console.WriteLine($"{Name} attacks for {damage} damage.");
            Enmity += damage * EnmityMultiplier;
            hasAttacked = true;
            return damage;
        }

        public virtual void ReceiveDamage(int damage)
        {
            Health = Health < damage ? Health = 0 
                                       : Health -= damage;
            Console.WriteLine($"{Name}'s health is reduced to {Health}. \n");

            if (Health == 0)
            {
                IsAlive = false;
            }
        }

        public void ReceiveHeal(int heal)
        {
            Console.WriteLine($"{Name} regenerates {heal} health from the spell.\n");
            Health += heal;
        }

        public bool LifeStatus()
        { return _isAlive; }

        public Fighter(string newName, int newHealth, int newDiceAmt)
        {
            Name = newName;
            Health = newHealth;
            DiceAmt = newDiceAmt;
            IsAlive = true;
            Min = 1;
            Max = 7;
            Enmity = 0;
            EnmityMultiplier = 3;
        }

    }
}
