using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorWar.Enum;

namespace WarriorWar.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_Damage = 10;
        private const int BAD_GUY_Damage = 5;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.Goodguy:
                    damage = GOOD_GUY_Damage;
                    break;
                case Faction.Badguy:
                    damage = BAD_GUY_Damage;
                    break;
                default:
                    break;
            }
        }
    }
}
