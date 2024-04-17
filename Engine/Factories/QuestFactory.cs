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
                "Retrieve a fragment ",
                "Defeat the Warlocks in the Oasis to get the fragment",
                itemsToComplete,
                25, 10,
                rewardItems));

            _standardQuests.Add(new Quest(
                2,
                "Retrieve a fragment ",
                "Defeat the Goblin in the Wasteland to get the fragment",
                itemsToComplete,
                25, 10,
                rewardItems));

            _standardQuests.Add(new Quest(
                3,
                "Retrieve a fragment",
                "Defeat the phantoms in the grove to get the fragment",
                itemsToComplete,
                25, 10,
                rewardItems));

            _standardQuests.Add(new Quest(
                4,
                "Retrieve a fragment",
                "Defeat the Ghouls in the Abandoned Dungeon to get the fragment",
                itemsToComplete,
                25, 10,
                rewardItems));

            _standardQuests.Add(new Quest(
                5,
                "Retrieve a fragment",
                "Defeat the Scorchflame in the Summit to get the fragment",
                itemsToComplete,
                25, 10,
                rewardItems));


        }

        internal static Quest GetQuestByID(int id)
        {
            return _standardQuests.FirstOrDefault(quest => quest.ID == id);

            return null;
        }
    }
}
