using WarriorWar.Enum;

namespace WarriorWar.Equipment
{
    class Armor
    {
        private const int GOOD_GUY_ARMOR_POINTS = 5;
        private const int BAD_GUY_AMRMOR_POINTS = 5;

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
                case Faction.Goodguy:
                    armorPoints = GOOD_GUY_ARMOR_POINTS;
                    break;
                case Faction.Badguy:
                    armorPoints = BAD_GUY_AMRMOR_POINTS;
                    break;
                default:
                    break;
            }

        }
    }
}