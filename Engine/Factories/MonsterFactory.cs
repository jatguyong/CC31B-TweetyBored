using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster warlock =
                        new Monster("Warlock", "pack://application:,,,/Engine;component/Images/Enemies/warlock.png", 4, 4, 5, 1);
                    AddLootItem(warlock, 2004, 25);
                    return warlock;
                case 2:
                    Monster goblin =
                        new Monster("Goblin", "pack://application:,,,/Engine;component/Images/Enemies/goblin.png", 5, 5, 5, 1);
                    AddLootItem(goblin, 2002, 25);
                    return goblin;
                case 3:
                    Monster phantom =
                        new Monster("Phantom", "pack://application:,,,/Engine;component/Images/Enemies/phantom.png", 10, 10, 10, 3);
                    AddLootItem(phantom, 2001, 25);
                    return phantom;
                case 4:
                    Monster ghoul =
                        new Monster("Ghoul", "pack://application:,,,/Engine;component/Images/Enemies/ghoul.png", 10, 10, 10, 3);
                    AddLootItem(ghoul, 2003, 25);
                    return ghoul;
                case 5:
                    Monster scorchflame =
                        new Monster("Scorchflame", "pack://application:,,,/Engine;component/Images/Enemies/scorchflame.png", 10, 10, 10, 3);
                    AddLootItem(scorchflame, 2005, 25);
                    return scorchflame;
                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}
