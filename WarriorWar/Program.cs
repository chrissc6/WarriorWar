using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarriorWar.Enum;

namespace WarriorWar
{
    class Program
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            WarriorClass goodGuy = new WarriorClass("Chris", Faction.Goodguy);
            WarriorClass badGuy = new WarriorClass("Bob", Faction.Badguy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
                Thread.Sleep(100);
            }
        }
    }
}
