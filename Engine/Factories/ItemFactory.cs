﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Inferno Blade", 199, " ", 50, 100));
            _standardGameItems.Add(new Weapon(1002, "Shadowstrike Scythe", 250, " ", 90, 200));
        }


        public static GameItem CreateGameItem(int itemTypeID)
        {
            // create new instances of game items

            if (_standardGameItems != null)
            {
                foreach(GameItem item in _standardGameItems)
                {
                    if(item.ItemTypeID == itemTypeID)
                    {
                        return item.Clone();
                    }
                }
            }

            return null;
        }
    }
}
