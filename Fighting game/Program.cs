Console.WriteLine("P1 enter your name");
string p1 = Console.ReadLine();

// Console.WriteLine("P2 enter your name");
// string p2 = Console.ReadLine();

int playerhp = 50;
int enemyhp = 50;

Random generator = new Random();
int tal = generator.Next(1,21);

Random gen = new Random();
int dmg = gen.Next(1,21);


while (playerhp > 0 && enemyhp > 0)
{
 playerhp-=tal;
 enemyhp-=dmg;   
}



Console.WriteLine("Press enter");
Console.ReadLine();