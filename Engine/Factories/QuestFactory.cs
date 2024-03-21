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
            // _standardQuests.Add(new Quest()); 

            // instantiate a quest; add the required arguments to parameters of Quest()
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
