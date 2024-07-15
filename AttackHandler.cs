using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOguerriersAreFiiighting
{
    internal class AttackHandler
    {
        public static void tankAttack(List<Fighter> teamAAlive, List<Fighter> teamBAlive)
        {
            for (int i = 0; i < teamAAlive.Count(); i++)
            {
                if (teamAAlive[i].GetType() == typeof(Tank))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
                }
            }

            for (int i = 0; i < teamBAlive.Count(); i++)
            {
                if (teamBAlive[i].GetType() == typeof(Tank))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
                }
            }
        }

        public static void healerAttack(List<Fighter> teamAAlive, List<Fighter> teamBAlive)
        {
            for (int i = 0; i < teamAAlive.Count(); i++)
            {
                if (teamAAlive[i].GetType() == typeof(Healer))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    teamAAlive[0].ReceiveHeal(teamAAlive[i].SendDamage());
                }
            }

            for (int i = 0; i < teamBAlive.Count(); i++)
            {
                if (teamBAlive[i].GetType() == typeof(Healer))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    teamBAlive[0].ReceiveHeal(teamBAlive[i].SendDamage());
                }
            }
        }

        public static void puncherAttack(List<Fighter> teamAAlive, List<Fighter> teamBAlive)
        {
            for (int i = 0; i < teamAAlive.Count(); i++)
            {
                if (teamAAlive[i].GetType() == typeof(Puncher))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
                }
            }

            for (int i = 0; i < teamBAlive.Count(); i++)
            {
                if (teamBAlive[i].GetType() == typeof(Puncher))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
                }
            }
        }

        public static void rangerAttack(List<Fighter> teamAAlive, List<Fighter> teamBAlive)
        {
            for (int i = 0; i < teamAAlive.Count(); i++)
            {
                if (teamAAlive[i].GetType() == typeof(Ranger))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
                }
            }

            for (int i = 0; i < teamBAlive.Count(); i++)
            {
                if (teamBAlive[i].GetType() == typeof(Ranger))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
                }
            }
        }

        public static void slasherAttack(List<Fighter> teamAAlive, List<Fighter> teamBAlive)
        {
            for (int i = 0; i < teamAAlive.Count(); i++)
            {
                if (teamAAlive[i].GetType() == typeof(Slasher))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
                }
            }

            for (int i = 0; i < teamBAlive.Count(); i++)
            {
                if (teamBAlive[i].GetType() == typeof(Slasher))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
                }
            }
        }

        public static void mageAttack(List<Fighter> teamAAlive, List<Fighter> teamBAlive)
        {
            for (int i = 0; i < teamAAlive.Count(); i++)
            {
                if (teamAAlive[i].GetType() == typeof(Mage))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
                }
            }

            for (int i = 0; i < teamBAlive.Count(); i++)
            {
                if (teamBAlive[i].GetType() == typeof(Mage))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
                }
            }
        }

        public static void cleanUpCorpses(List<Fighter> teamAAlive, List<Fighter> teamBAlive, Fighter[] teamA, Fighter[] teamB)
        {
            foreach (Fighter teammate in teamA)
            {
                if (!teammate.LifeStatus())
                {
                    teamAAlive.Remove(teammate);
                }
            }

            foreach (Fighter teammate in teamB)
            {
                if (!teammate.LifeStatus())
                {
                    teamBAlive.Remove(teammate);
                }
            }
        }
        public static void refreshEnmityList(List<Fighter> teamAAlive, List<Fighter> teamBAlive)
        {
            teamAAlive = teamAAlive.OrderBy(teammate => teammate.Enmity).ToList();
            teamAAlive.Reverse();
            teamBAlive = teamBAlive.OrderBy(teammate => teammate.Enmity).ToList();
            teamBAlive.Reverse();
        }
        private AttackHandler() { }
    }
}
