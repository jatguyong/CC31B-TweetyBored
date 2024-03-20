using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ImageName { get; set; }

        public GameItem(int itemTypeID, string name, int price, int imageName) { 
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            ImageName = imageName;
        }

        public virtual GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, ImageName);
        }
    }
}
