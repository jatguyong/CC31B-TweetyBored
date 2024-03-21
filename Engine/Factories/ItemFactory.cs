using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Models.Items;

namespace Engine.Factories
{
    public class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Inferno Blade", 199, "pack://application:,,,/Engine;component/Images/Items/Weapons/inferno_blade.png", 50, 70));
            _standardGameItems.Add(new Weapon(1002, "Shadowstrike Scythe", 250, "pack://application:,,,/Engine;component/Images/Items/Weapons/shadowstrike_scythe.png", 70, 90));
            
            _standardGameItems.Add(new Fragment(1003, "Oasis Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/fragment.png", 20));
            _standardGameItems.Add(new Fragment(1004, "Summit Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/fragment.png", 20));
            _standardGameItems.Add(new Fragment(1005, "Wasteland Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/fragment.png", 20));
            _standardGameItems.Add(new Fragment(1006, "Grove Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/fragment.png", 20));
            _standardGameItems.Add(new Fragment(1007, "Abandoned Dungeon Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/fragment.png", 20));
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
