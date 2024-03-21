using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Items
{
    public class CoralReefs : GameItem
    {
        
        public CoralReefs(int itemTypeID, string name, int price, string imageName) : base(itemTypeID, name, price, imageName)
        {
        }
    }
}
