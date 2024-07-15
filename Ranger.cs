using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class Ranger : Fighter
    {
        public Ranger(string newName, int newHealth, int newDiceAmt)
            : base(newName, newHealth, newDiceAmt)
        {
            Min = 2;
            Max = 7;
            EnmityMultiplier = 1;
        }
    }
}
