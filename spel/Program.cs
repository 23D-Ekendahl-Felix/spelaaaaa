string Spelare1 = "Spelare1";
string Spelare2 "Spelare2";

int Spelare1hp = 100;
int Spelare2hp = 100;

Random = new Random();

while (heroHp > 0 && villainHp > 0)
{
  Console.WriteLine("\n Ny runda");
  Console.WriteLine($"{Spelare1}: {Spelare1Hp}  {Spelare2}: {Spelare2Hp}\n");

  int Spelare1Damage = generator.Next(20);
  Spelare2Hp -= Spelare1Damage;
  Spelare2Hp = Math.Max(0, Spelare2Hp);
  Console.WriteLine($"{Spelare1} gör {Spelare1Damage} skada på {Spelare2}");

  int Spelare2Damage = generator.Next(20);
  Spelare1Hp -= Spelare2Damage;
  Spelare1Hp = Math.Max(0, Spelare1Hp);
  Console.WriteLine($"{Spelare2Name} gör {Spelare2Damage} skada på {Spelare1}");

  Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
  Console.ReadKey();
}

System.Console.WriteLine("\n Slut");

if (Spelare1hp == 0 && == 0)
{
    System.Console.WriteLine("oavgjort");
}
else if (Spelare1hp == 0)
{
System.Console.WriteLine($"{Spelare2} Vann!");
}
else
{
    System.Console.WriteLine($"{Spelare1} vann!");
}

System.Console.WriteLine("Tryck på valfri knapp för att avsluta");
console.Readkey();
