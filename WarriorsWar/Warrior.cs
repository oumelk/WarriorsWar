using WarriorsWar.Enums;
using WarriorsWar.Equipments;

namespace WarriorsWar
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 10;
        private const int BAD_GUY_STARTING_HEALTH = 10;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;

        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;  
            FACTION = faction;
            isAlive = true;
            weapon = new Weapon(faction);
            armor = new Armor(faction);

            switch (faction)
            {
                case Faction.GoodGuy:
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            Console.WriteLine($"{name} attacks {enemy.name}, {damage} damage was inflected to {enemy.name}, {enemy.name} health is {enemy.health}");

            if (enemy.health <= 0) 
            {
                enemy.isAlive = false;

                Tools.ColorfulWriteLine($"{enemy.name} is dead!.", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} won.", ConsoleColor.Green);
            }
        }
    }
}
