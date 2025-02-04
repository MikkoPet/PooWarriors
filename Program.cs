﻿using POOguerriersAreFiiighting;
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

// We keep the whole teams listed in an array, then send them to a mirrored list that we'll
// be able to comfortably modify to reflect only the alive teammates.

Fighter[] teamA = [shanksie, rae, cassie, linda, pink];
Fighter[] teamB = [terminator, george, sugar, avarae, pearl];

List<Fighter> teamAAlive = new List<Fighter>();
List<Fighter> teamBAlive = new List<Fighter>();

foreach (Fighter teammate in teamA)
{ teamAAlive.Add(teammate); }

foreach (Fighter teammate in teamB)
{ teamBAlive.Add(teammate); }

Console.WriteLine("Teams have been built.");

// The game runs automatically til total death of one team
while (teamAAlive.Count() > 0 && teamBAlive.Count() > 0)
{
    //Each "turn" runs on 60 ticks, after which it resets to 0. This allows different fighter types to attack at different intervals.
    //Tanks always attack first, once per turn.
    //Healers always attack last, once per turn.
    //Punchers are fastest (martial artist type), and attack five times,
    //then Rangers attack four times, Slashers three, and Mages two times.

    // when the ticks match the count needed for each type,
    // the program cycles through the list of live members of each team
    // and triggers the attack of each matching type.

    if (Fighter.turns == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        AttackHandler.tankAttack(teamAAlive, teamBAlive);
        Console.ForegroundColor = ConsoleColor.Cyan;
        AttackHandler.tankAttack(teamBAlive, teamAAlive);
    }

    if (Fighter.turns == 60)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        AttackHandler.healerAttack(teamAAlive, teamBAlive);
        Console.ForegroundColor = ConsoleColor.Cyan;
        AttackHandler.healerAttack(teamBAlive, teamAAlive);
    }

    if (Fighter.turns % 12 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        AttackHandler.puncherAttack(teamAAlive, teamBAlive);
        Console.ForegroundColor = ConsoleColor.Cyan;
        AttackHandler.puncherAttack(teamBAlive, teamAAlive);
    }

    if (Fighter.turns % 15 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        AttackHandler.rangerAttack(teamAAlive, teamBAlive);
        Console.ForegroundColor = ConsoleColor.Cyan;
        AttackHandler.rangerAttack(teamBAlive, teamAAlive);
    }

    if (Fighter.turns % 20 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        AttackHandler.slasherAttack(teamAAlive, teamBAlive);
        Console.ForegroundColor = ConsoleColor.Cyan;
        AttackHandler.slasherAttack(teamBAlive, teamAAlive);
    }

    if (Fighter.turns % 30 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        AttackHandler.mageAttack(teamAAlive, teamBAlive);
        Console.ForegroundColor = ConsoleColor.Cyan;
        AttackHandler.mageAttack(teamBAlive, teamAAlive);
    }

    //on ticks where at least an attack occured,
    // the game searches for dead teammates and removes them from the list
    // then, the list is sorted to have the teammate with the most enmity first
    // (check class fighter for breakdown on enmity generation)

    Console.ForegroundColor = ConsoleColor.White;
    if (Fighter.hasAttacked)
    {
        AttackHandler.cleanUpCorpses(teamAAlive, teamA);
        AttackHandler.cleanUpCorpses(teamBAlive, teamB);
        AttackHandler.refreshEnmityList(teamAAlive);
        AttackHandler.refreshEnmityList(teamBAlive);

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

// the game ends when one team's alive list has reached zero
// so if teamA has a count different from 0, it means it won, and the opposite means teamB won

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
