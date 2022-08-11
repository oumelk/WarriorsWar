using WarriorsWar.Enums;

namespace WarriorsWar.Equipments
{
    class Armor
    {
        private const int GOOD_GUY_ARMOR_POINTS = 5;
        private const int BAD_GUY_ARMOR_POINTS = 5;  

        private int armorPoints;

        public int ArmorPoints 
        {
            get 
            {
                return armorPoints; 
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR_POINTS;
                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR_POINTS;
                    break;
                default:
                    break;
            }
        }
    }
}