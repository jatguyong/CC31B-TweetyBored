using Engine.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon("1001", "Pointy Stick", 99, "image.png", 0, 100)); // example
        }

        public static void CreateGameItem()
        {
            // next instructions: After creating the static constructor and initializing the GameItems... {onwards}
        }
    }
}
