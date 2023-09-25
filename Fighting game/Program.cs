Console.WriteLine("P1 enter your name");
string p1 = Console.ReadLine();


string p2 = "Enemy";

int playerhp = 50;
int enemyhp = 50;

Random generator = new Random();




while (playerhp > 0 && enemyhp > 0)
{
    Console.WriteLine($"{p1}: {playerhp}hp   {p2}: {enemyhp}hp\n");


    int tal = generator.Next(1,21);
    enemyhp-=tal;
    enemyhp = Math.Max(0, enemyhp);
    Console.WriteLine($"{p1} deals {tal} damage to the enemy");

    int dmg = generator.Next(1,21);
    playerhp-=dmg;
    playerhp = Math.Max(0, playerhp);
    Console.WriteLine($"{p2} deals {dmg} damage to {p1}");

    Console.WriteLine("Press enter to start new round");
    Console.ReadLine();

}

if (playerhp == 0 && enemyhp == 0)
{
    Console.WriteLine("Tie");
}
else if (playerhp == 0)
{
    Console.WriteLine("You Lose");
}
else
{
    Console.WriteLine("Congratulations, You Win");
}

Console.WriteLine($"\n{p1}: {playerhp}hp   {p2}: {enemyhp}hp");


Console.WriteLine("\nPress enter to close the game");
Console.ReadLine();