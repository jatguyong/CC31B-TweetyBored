using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static List<Quest> _standardQuests = new List<Quest>();

        static QuestFactory()
        {
            // items needed to complete and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(1001, 5));
            rewardItems.Add(new ItemQuantity(2001, 1));

            _standardQuests.Add(new Quest(
                1,
                "Retrieve a fragment",
                "Defeat the phantoms in the grove to get the fragment",
                itemsToComplete,
                25, 10,
                rewardItems));

            /*
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
                "Defeat the Ghouls",
                 new List<ItemQuantity> { new ItemQuantity(2, 1) }, 
                25, 5,
                new List<ItemQuantity> { new ItemQuantity(1001, 2) }));
            _standardQuests.Add(new Quest(
                3,
                "Battle3",
                "Defeat the Goblins",
                 new List<ItemQuantity> { new ItemQuantity(3, 1) },
                25, 5,
                new List<ItemQuantity> { new ItemQuantity(1001, 2) }));
            _standardQuests.Add(new Quest(
                4,
                "Battle4",
                "Defeat the Warlocks",
                 new List<ItemQuantity> { new ItemQuantity(4, 1) },
                25, 5,
                new List<ItemQuantity> { new ItemQuantity(1001, 2) }));
            _standardQuests.Add(new Quest(
                5,
                "Battle5",
                "Defeat the Scorchflame",
                 new List<ItemQuantity> { new ItemQuantity(5, 1) },
                25, 5,
                new List<ItemQuantity> { new ItemQuantity(1001, 2) }));*/
        }

        internal static Quest GetQuestByID(int id)
        {
            return _standardQuests.FirstOrDefault(quest => quest.ID == id);

            return null;
        }
    }
}
