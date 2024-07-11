using POOguerriersAreFiiighting;
using System;

string winners;

Nain danDwarf = new Nain("Dan the dwarf", 50, 1, 3);
Elf ralphElf = new Elf("Ralph the elf", 22, 3);
Guerrier willyGuerrier = new Guerrier("Willy the Warrior", 50, 2);

Nain davidDwarf = new Nain("David the dwarf", 50, 1, 3);
Elf enzoElf = new Elf("Enzo the Elf", 22, 3);
Guerrier georgeGuerrier = new Guerrier("Georges the 'Guerrier'", 50, 2);


Guerrier[] teamA = [ ralphElf, willyGuerrier, danDwarf];
Guerrier[] teamB = [ davidDwarf, enzoElf, georgeGuerrier];

int iTeamA = 0;
int iTeamB = 0;

while (iTeamA < teamA.Length && iTeamB < teamB.Length)
{
    while (teamA[iTeamA].LifeStatus() && teamB[iTeamB].LifeStatus())
    {
        if (Guerrier.turns % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            teamB[iTeamB].ReceiveDamage(teamA[iTeamA].SendDamage());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            teamA[iTeamA].ReceiveDamage(teamB[iTeamB].SendDamage());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This concludes turn " + Guerrier.turns / 2);
            Console.WriteLine("Press any key to continue. \n");
            Console.ReadKey();

        }
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n {(teamA[iTeamA].LifeStatus() ? teamA[iTeamA].Name : teamB[iTeamB].Name)} has won the fight in {(Guerrier.turns / 2)} turns. \n");

    Guerrier.resetTurns();

    if (teamA[iTeamA].LifeStatus())
    {
        iTeamB++;
    }
    else
    {
        iTeamA++;
        Guerrier.turns++;
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
