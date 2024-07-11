using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Elf : Guerrier
    {
        public Elf(string newName, int newHealth, int newDiceAmt)
            : base(newName, newHealth, newDiceAmt)
        {
            Min = 2;
            Max = 7;
        }
    }
}
