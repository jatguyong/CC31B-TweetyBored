using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public class QuestFactory
    {
        private static List<Quest> _standardQuests;

        static QuestFactory()
        {
            _standardQuests = new List<Quest>();
            _standardQuests.Add(new Quest(
                1,
                "Battle",
                "Defeat the Phantom",
                new List<ItemQuantity> { new ItemQuantity(1,1)},
                25,10,
                new List<ItemQuantity> { new ItemQuantity(1001,1) }));
            _standardQuests.Add(new Quest(
                2, 
                "Battle2", 
                "Defeat the enemy",
                 new List<ItemQuantity> { new ItemQuantity(2, 1) }, 
                25, 5,
                new List<ItemQuantity> { new ItemQuantity(1001, 2) }));
        }

        public Quest GetQuestByID(int id)
        {
            if (_standardQuests != null)
            {
                foreach (Quest item in _standardQuests)
                {
                    if (item.ID == id)
                    {
                        return item; // return the quest
                    }
                }
            }

            return null;
        }
    }
}
