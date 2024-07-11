using POOguerriersAreFiiighting;

Guerrier winner;

Guerrier defineWinner(Guerrier warriorFirst, Guerrier warriorSecond)
{
    if (warriorFirst.Health == 0)
    {
        return warriorSecond;
    }
    else
    {
        return warriorFirst;
    }
}

Guerrier warrior1 = new Nain("Dan the dwarf", 50, 1, 3);
Guerrier warrior2 = new Elf("Ralph the elf", 22, 3);
winner = new Guerrier("", 0, 0);

while (warrior1.Health > 0 && warrior2.Health > 0)
{
    if (Guerrier.turns % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        warrior2.OuchOuch(warrior1.TurnDamage());
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        warrior1.OuchOuch(warrior2.TurnDamage());

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This concludes turn " + Guerrier.turns / 2);
        Console.WriteLine("Press any key to continue. \n \n");
        Console.ReadKey();

    }
}

winner = defineWinner(warrior2, warrior1);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n \n After {Guerrier.turns} turns, {winner.Name} has won the fight");
Console.ForegroundColor = ConsoleColor.White;
