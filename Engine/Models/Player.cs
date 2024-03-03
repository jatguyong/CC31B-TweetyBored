using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {
        // properties
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int Level { get; set; }
        public int Coin { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }
    }
}
