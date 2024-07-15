using POOguerriersAreFiiighting;
using System;

string winners;

Tank shanksie = new Tank("Shank", 50, 1, 3);
Mage cassie = new Mage("Cass", 20, 5);
Puncher linda = new Puncher("Linda", 22, 3);
Fighter rae = new Fighter("Rae", 30, 3);
Healer pink = new Healer("Pink", 15, 2);

Tank davidDwarf = new Tank("David the dwarf", 50, 1, 3);
Ranger enzoElf = new Ranger("Enzo the Elf", 22, 3);
Fighter georgeGuerrier = new Fighter("Georges the 'Guerrier'", 50, 2);


Fighter[] teamA = [ ];
Fighter[] teamB = [ ];

/* 
WE NEED:
    teamDeaths = for A & B, foreach (guy in teamX) { if !guy.LifeStat iterate counter }
    would need to run after each turn?

    targetTeamA & targetTeamB defines who they attack, and who the healers heal.
    target order Tanks > Fightr > Punch > Mage > Ranged > Healer
    if target dies switch to next?
    
 */

#region basic program

//int iTeamA = 0;
//int iTeamB = 0;

//while (iTeamA < teamA.Length && iTeamB < teamB.Length)
//{
//    while (teamA[iTeamA].LifeStatus() && teamB[iTeamB].LifeStatus())
//    {
//        if (Fighter.turns % 2 == 0)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            teamB[iTeamB].ReceiveDamage(teamA[iTeamA].SendDamage());
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            teamA[iTeamA].ReceiveDamage(teamB[iTeamB].SendDamage());

//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine("This concludes turn " + Fighter.turns / 2);
//            Console.WriteLine("Press any key to continue. \n");
//            Console.ReadKey();

//        }
//    }

//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"\n {(teamA[iTeamA].LifeStatus() ? teamA[iTeamA].Name : teamB[iTeamB].Name)} has won the fight in {(Fighter.turns / 2)} turns. \n");

//    Fighter.resetTurns();

//    if (teamA[iTeamA].LifeStatus())
//    {
//        iTeamB++;
//    }
//    else
//    {
//        iTeamA++;
//        Fighter.turns++;
//    }

//}

//if (iTeamA == 2)
//{
//    winners = $"{teamA[0].Name}, {teamA[1].Name} & {teamA[2].Name}";
//}
//else
//{
//    winners = $"{teamB[0].Name}, {teamB[1].Name} & {teamB[2].Name}";
//}
# endregion

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n \n {winners} have won the fight");
Console.ForegroundColor = ConsoleColor.White;
