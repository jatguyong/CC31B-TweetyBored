using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Fragment : GameItem
    {

        public Fragment(int itemTypeID, string name, int price, string imageName) : base(itemTypeID, name, price, imageName)
        {
        }

        public override Fragment Clone()
        {
            return new Fragment(ItemTypeID, Name, Price, ImageName);
        }
    }
}
