using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Items
{
    public class Weapon : GameItem
    {
        private int MinimumDamage { get; set; }
        private int MaximumDamage { get; set; }

        public Weapon(int itemTypeID, string name, int price, string imageName, int minimumDamage, int maximumDamage) : base(itemTypeID, name, price, imageName)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }

        public override Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, ImageName, MinimumDamage, MaximumDamage);
        }
    }


}
