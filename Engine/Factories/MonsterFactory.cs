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
                        new Monster("Warlock", "Snake.png", 4, 4, 5, 1);
                    AddLootItem(warlock, 9001, 25);
                    AddLootItem(warlock, 9002, 75);
                    return warlock;
                case 2:
                    Monster goblin =
                        new Monster("Goblin", "Rat.png", 5, 5, 5, 1);
                    AddLootItem(goblin, 9003, 25);
                    AddLootItem(goblin, 9004, 75);
                    return goblin;
                case 3:
                    Monster phantom =
                        new Monster("Phantom", "GiantSpider.png", 10, 10, 10, 3);
                    AddLootItem(phantom, 9005, 25);
                    AddLootItem(phantom, 9006, 75);
                    return phantom;
                case 4:
                    Monster ghoul =
                        new Monster("Ghoul", "GiantSpider.png", 10, 10, 10, 3);
                    AddLootItem(ghoul, 9005, 25);
                    AddLootItem(ghoul, 9006, 75);
                    return ghoul;
                case 5:
                    Monster scorchflame =
                        new Monster("Scorchflame", "GiantSpider.png", 10, 10, 10, 3);
                    AddLootItem(scorchflame, 9005, 25);
                    AddLootItem(scorchflame, 9006, 75);
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
