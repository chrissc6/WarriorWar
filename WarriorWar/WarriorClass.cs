using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorWar.Enum;
using WarriorWar.Equipment;

namespace WarriorWar
{
    class WarriorClass
    {
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

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


        public void Attack(WarriorClass enemy)
        {
            //int damage = weapon.Damage / enemy.armor.ArmorPoints;
            int damage = weapon.Damage;
            enemy.health -= damage;

            AttackResult(enemy, damage);
        }

        private void AttackResult(WarriorClass enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                //Console.WriteLine($"{enemy.name} has fainted. \n{name} has won the battle.");
                Tools.ColorfulWriteLine($"{enemy.name} has fainted.", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} has won the battle.", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. Dealt {damage} damage, {enemy.name} remaining health is {enemy.health}");
            }
        }




        public WarriorClass(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.Goodguy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.Badguy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }
    }
}
