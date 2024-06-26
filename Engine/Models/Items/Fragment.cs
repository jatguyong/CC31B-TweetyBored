﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Items
{
    public class Fragment : GameItem
    {
        private int DropRate {  get; set; }

        public Fragment(int itemTypeID, string name, int price, string imageName, int dropRate) : base(itemTypeID, name, price, imageName)
        {
            DropRate = dropRate;
        }

        public new Fragment Clone()
        {
            return new Fragment(ItemTypeID, Name, Price, ImageName, DropRate);
        }
    }
}
