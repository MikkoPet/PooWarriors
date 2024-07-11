using POOguerriersAreFiiighting;
using System;


Guerrier warrior1 = new Nain("Dan the dwarf", 50, 1, 3);
Guerrier warrior2 = new Elf("Ralph the elf", 22, 3);

while (warrior1.Health > 0 && warrior2.Health > 0)
{
    if (Guerrier.turns % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        warrior2.ReceiveDamage(warrior1.SendDamage());
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        warrior1.ReceiveDamage(warrior2.SendDamage());

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This concludes turn " + Guerrier.turns / 2);
        Console.WriteLine("Press any key to continue. \n \n");
        Console.ReadKey();

    }
}


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n \n After {Guerrier.turns} blows, {(warrior1.LifeStatus() ? warrior1.Name : warrior2.Name)} has won the fight");
Console.ForegroundColor = ConsoleColor.White;
