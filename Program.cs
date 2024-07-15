using POOguerriersAreFiiighting;
using System;
using System.Runtime.ExceptionServices;

string winners = String.Empty;

Tank shanksie = new Tank("Shank the Tank", 50, 1, 3);
Mage cassie = new Mage("Cass the Mage", 20, 5);
Puncher linda = new Puncher("Auntie Linda", 22, 3);
Slasher rae = new Slasher("Rae the Warrior", 30, 3);
Healer pink = new Healer("Pink the Healer", 15, 3);

Tank terminator = new Tank("The Terminator", 50, 1, 2);
Ranger sugar = new Ranger("Sugar the Archer", 22, 3);
Slasher george = new Slasher("Georges, Swordsman for hire", 50, 2);
Healer avarae = new Healer("Avarae the Healer", 20, 2);
Mage pearl = new Mage("Pearl the Mage", 25, 3);


Fighter[] teamA = [shanksie, rae, cassie, linda, pink];
Fighter[] teamB = [terminator, george, sugar, avarae, pearl];

List<Fighter> teamAAlive = new List<Fighter>();
List<Fighter> teamBAlive = new List<Fighter>();

foreach (Fighter teammate in teamA)
{ teamAAlive.Add(teammate); }

foreach (Fighter teammate in teamB)
{ teamBAlive.Add(teammate); }


//what about a team with multiple of a same role?
//foreach with array of indexes?

Console.WriteLine("Teams have been built.");

while (teamAAlive.Count() > 0 && teamBAlive.Count() > 0)
{

    if (Fighter.turns == 1)
    {
        for (int i = 0; i < teamAAlive.Count(); i++)
        {
            if (teamAAlive[i].GetType() == typeof(Tank))
            {
                teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
            }
        }

        for (int i = 0; i < teamBAlive.Count(); i++)
        {
            if (teamBAlive[i].GetType() == typeof(Tank))
            {
                teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
            }
        }
    }

    if (Fighter.turns == 60)
    {
        for (int i = 0; i < teamAAlive.Count(); i++)
        {
            if (teamAAlive[i].GetType() == typeof(Healer))
            {
                teamAAlive[0].ReceiveHeal(teamAAlive[i].SendDamage());
            }
        }

        for (int i = 0; i < teamBAlive.Count(); i++)
        {
            if (teamBAlive[i].GetType() == typeof(Healer))
            {
                teamBAlive[0].ReceiveHeal(teamBAlive[i].SendDamage());
            }
        }
    }

    if (Fighter.turns % 12 == 0)
    {
        for (int i = 0; i < teamAAlive.Count(); i++)
        {
            if (teamAAlive[i].GetType() == typeof(Puncher))
            {
                teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
            }
        }

        for (int i = 0; i < teamBAlive.Count(); i++)
        {
            if (teamBAlive[i].GetType() == typeof(Puncher))
            {
                teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
            }
        }
    }

    if (Fighter.turns % 15 == 0)
    {
        for (int i = 0; i < teamAAlive.Count(); i++)
        {
            if (teamAAlive[i].GetType() == typeof(Ranger))
            {
                teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
            }
        }

        for (int i = 0; i < teamBAlive.Count(); i++)
        {
            if (teamBAlive[i].GetType() == typeof(Ranger))
            {
                teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
            }
        }
    }

    if (Fighter.turns % 20 == 0)
    {
        for (int i = 0; i < teamAAlive.Count(); i++)
        {
            if (teamAAlive[i].GetType() == typeof(Slasher))
            {
                teamBAlive[0].ReceiveDamage(teamAAlive[i].SendDamage());
            }
        }

        for (int i = 0; i < teamBAlive.Count(); i++)
        {
            if (teamBAlive[i].GetType() == typeof(Slasher))
            {
                teamAAlive[0].ReceiveDamage(teamBAlive[i].SendDamage());
            }
        }
    }

    if (Fighter.turns % 30 == 0)
    {
        for (int i = 0; i < teamAAlive.Count(); i++)
        {
            if (teamAAlive[i].GetType() == typeof(Mage))
            {
                teamBAlive[0].ReceiveDamage(teamA[i].SendDamage());
            }
        }

        for (int i = 0; i < teamBAlive.Count(); i++)
        {
            if (teamBAlive[i].GetType() == typeof(Mage))
            {
                teamAAlive[0].ReceiveDamage(teamB[i].SendDamage());
            }
        }
    }


    if (Fighter.hasAttacked)
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

        teamAAlive = teamAAlive.OrderBy(teammate => teammate.Enmity).ToList();
        teamAAlive.Reverse();
        teamBAlive = teamBAlive.OrderBy(teammate => teammate.Enmity).ToList();
        teamBAlive.Reverse();

        Fighter.hasAttacked = false;
    }

    Fighter.turns++;
    if (Fighter.turns == 61)
    {
        Console.WriteLine("The turn has ended. Press any key to continue.");
        Console.ReadKey();
        Fighter.turns = 0;
    }

}


if (teamAAlive.Count() != 0)
{
    for (int i = 0; i < teamA.Count() - 1; i++)
    { winners += teamA[i].Name + ", "; }
    winners += "& " + teamA[teamA.Count() - 1].Name;
}
else
{
    for (int i = 0; i < teamB.Count() - 1; i++)
    { winners += teamB[i].Name + ", "; }
    winners += "& " + teamB[teamB.Count() - 1].Name;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n \n {winners} have won the fight");
Console.ForegroundColor = ConsoleColor.White;
