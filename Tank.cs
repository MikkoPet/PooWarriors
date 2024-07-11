using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Tank : Fighter
    {

        private int _armour;

        public int Armour {  get => _armour ; set => _armour = value ; }

        public override void ReceiveDamage(int damage)
        {
            Health = Health + Armour < damage ? Health = 0 
                                               : damage < Armour ? Health -= 0 
                                               : Health -= damage - Armour;


            Console.WriteLine($"{Name}'s armour reduces the hit by {Armour}'s points of damage." +
                                $"\n {Name}'s health is reduced to {Health}.");

            if (Health == 0)
            {
                IsAlive = false;
            }
        }

        public Tank(string newName, int newHealth, int newDiceAmt, int newArmour) 
            : base (newName, newHealth, newDiceAmt)
        {
            Armour = newArmour ;
            _speed = 2;
        }
    }
}
