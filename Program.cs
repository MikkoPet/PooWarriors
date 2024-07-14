using POOguerriersAreFiiighting;
using System;

string winners;

Tank shanksie = new Tank("Shank", 50, 1, 3);
Mage cassie = new Mage("Cass", 22, 3);
Puncher auntLinda = new Puncher("Auntie Linda", 50, 2);

Tank david = new Tank("David", 50, 1, 3);
Ranger enzo = new Ranger("Enzo", 22, 3);
Fighter george = new Fighter("Georges", 50, 2);


Fighter[] teamA = [ cassie, auntLinda, shanksie];
Fighter[] teamB = [ davidDwarf, enzoElf, georgeGuerrier];

int iTeamA = 0;
int iTeamB = 0;

while (iTeamA < teamA.Length && iTeamB < teamB.Length)
{
    while (teamA[iTeamA].LifeStatus() && teamB[iTeamB].LifeStatus())
    {
        if (Fighter.turns % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            teamB[iTeamB].ReceiveDamage(teamA[iTeamA].SendDamage());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            teamA[iTeamA].ReceiveDamage(teamB[iTeamB].SendDamage());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This concludes turn " + Fighter.turns / 2);
            Console.WriteLine("Press any key to continue. \n");
            Console.ReadKey();

        }
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n {(teamA[iTeamA].LifeStatus() ? teamA[iTeamA].Name : teamB[iTeamB].Name)} has won the fight in {(Fighter.turns / 2)} turns. \n");

    Fighter.resetTurns();

    if (teamA[iTeamA].LifeStatus())
    {
        iTeamB++;
    }
    else
    {
        iTeamA++;
        Fighter.turns++;
    }

}

if (iTeamA == 2)
{
    winners = $"{teamA[0].Name}, {teamA[1].Name} & {teamA[2].Name}";
}
else
{
    winners = $"{teamB[0].Name}, {teamB[1].Name} & {teamB[2].Name}";
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n \n {winners} have won the fight");
Console.ForegroundColor = ConsoleColor.White;
