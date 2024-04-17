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
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Inferno Blade", 199, "pack://application:,,,/Engine;component/Images/Weapons/inferno_blade.png", 15, 20));
            _standardGameItems.Add(new Weapon(1002, "Shadowstrike Scythe", 250, "pack://application:,,,/Engine;component/Images/Weapons/shadowstrike_scythe.png", 70, 90));

            _standardGameItems.Add(new Fragment(2001, "Grove Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/grove_fragment.png", 20));
            _standardGameItems.Add(new Fragment(2002, "Wasteland Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/wasteland_fragment.png", 20));
            _standardGameItems.Add(new Fragment(2003, "Abandoned Dungeon Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/dungeon_fragment.png", 20));
            _standardGameItems.Add(new Fragment(2004, "Oasis Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/oasis_fragment.png", 20));
            _standardGameItems.Add(new Fragment(2005, "Summit Fragment", 0, "pack://application:,,,/Engine;component/Images/Items/Fragments/summit_fragment.png", 20));
        }


        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);


            if (standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                return standardItem.Clone();
            }
            return null;
        }
    }
}
