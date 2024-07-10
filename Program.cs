using POOguerriersAreFiiighting;

void attack(Guerrier warriorAttacking, Guerrier warriorAttacked)
{
    int damage = warriorAttacking.TurnDamage() - warriorAttacked.Armour;


    if (warriorAttacked.Health >= damage)
    {
        warriorAttacked.Health -= damage;
    }
    else
    {
        warriorAttacked.Health = 0;
    }

    Console.WriteLine(warriorAttacking.Name + " attacks " + warriorAttacked.Name 
                        + " for " + damage + " damage. " 
                        + warriorAttacked.Name + "'s health is now at " + warriorAttacked.Health);
}

Guerrier warrior1 = new Nain("Dan the dwarf", 50, 1, 3);
Guerrier warrior2 = new Elf("Ralph the elf", 25, 2);

while (warrior1.Health > 0 && warrior2.Health > 0)
{
    if (Guerrier.turns % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        attack(warrior1, warrior2);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        attack(warrior2, warrior1);
    }
    
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("The fight has ended after " + Guerrier.turns + " turns.");