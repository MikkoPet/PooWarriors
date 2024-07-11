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
        protected int   _speed;
        #endregion


        #region properties
        public string Name { get => _name; set => _name = value == String.Empty ? "Warrior" : value; }
        public int Health { get => _health; set => _health = value; }
        protected int DiceAmt { get => _diceAmt; set => _diceAmt = value; }
        protected int Min { get => _minAttackPotency; set => _minAttackPotency = value; }
        protected int Max { get => _maxAttackPotency; set => _maxAttackPotency = value; }
        protected bool IsAlive { get => _isAlive; set => _isAlive = value; }
        public int Speed { get => _speed; }
        #endregion


        public static int turns = 0;
         
        public static void resetTurns()
        {
            turns = 0;
        }

        public virtual int SendDamage()
        {
            turns++;
            int damage = new Random().Next(Min * DiceAmt, Max * DiceAmt);
            Console.WriteLine($"{Name} attacks for {damage} damage.");
            return damage;
        }

        public virtual void ReceiveDamage(int damage)
        {
            Health = Health < damage ? Health = 0 
                                       : Health -= damage;
            Console.WriteLine($"{Name}'s health is reduced to {Health}.");

            if (Health == 0)
            {
                IsAlive = false;
            }
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
            _speed = 3;
        }

    }
}
