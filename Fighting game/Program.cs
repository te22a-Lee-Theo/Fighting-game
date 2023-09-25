Console.WriteLine("P1 enter your name");
string p1 = Console.ReadLine();


string p2 = "Enemy";

int playerhp = 50;
int enemyhp = 50;

Random generator = new Random();




while (playerhp > 0 && enemyhp > 0)
{
    Console.WriteLine($"{p1}: {playerhp}   {p2}: {enemyhp}\n");


    int tal = generator.Next(1,21);
    enemyhp-=tal;
    Console.WriteLine($"{p1} deals {tal} damage to the enemy");

    int dmg = generator.Next(1,21);
    playerhp-=dmg;
    Console.WriteLine($"{p2} deals {dmg} damage to {p1}");

    Console.WriteLine("Press enter to start new round");
    Console.ReadLine();

}





Console.WriteLine("Press enter to close the game");
Console.ReadLine();