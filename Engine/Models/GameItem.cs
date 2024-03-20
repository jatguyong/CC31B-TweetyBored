using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        private string _itemTypeID;
        private string _name;
        private int _price;
        private string _imageName;
        

        public string ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }

        public GameItem(string itemTypeID, string name, int price, string imageName) { 
            _itemTypeID = itemTypeID;
            _name = name;
            _price = price;
            _imageName = imageName;
        }
    }
}
