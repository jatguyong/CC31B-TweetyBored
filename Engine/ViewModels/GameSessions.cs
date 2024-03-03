using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jenny";
            // name must be user input
            CurrentPlayer.CharacterClass = "Soulweaver";
            CurrentPlayer.Level = 0;
            CurrentPlayer.Coin = 0;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;

        }
    }
}
