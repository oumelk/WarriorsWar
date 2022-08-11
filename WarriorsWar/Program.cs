using WarriorsWar;
using WarriorsWar.Enums;

Warrior badGuy = new Warrior("imane", Faction.BadGuy);
Warrior goodGuy = new Warrior("salah", Faction.GoodGuy);

Random rand = new Random();

while (badGuy.IsAlive && goodGuy.IsAlive)
{
    if(rand.Next(0, 10) < 5)
    {
        badGuy.Attack(goodGuy);
    }
    else
    {
        goodGuy.Attack(badGuy);
    }

    Thread.Sleep(700);
}