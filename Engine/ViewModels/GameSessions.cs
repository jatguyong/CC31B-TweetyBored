using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location _currentLocation;

        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "User";
            // name must be user input
            CurrentPlayer.CharacterClass = "Soulweaver";
            CurrentPlayer.Level = 1;
            CurrentPlayer.Coin = 0;
            CurrentPlayer.HitPoints = 20;
            CurrentPlayer.ExperiencePoints = 0;

            WorldFactory worldFactory = new WorldFactory();
            CurrentWorld = worldFactory.CreateWorld(); // the CurrentWorld is whatever the WorldFactory created in its CreateWorld()
            CurrentLocation = CurrentWorld.GetLocation(0, 0);
        }


        public Location CurrentLocation {
            get
            {
                return _currentLocation;
            }
            set
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
                // refresh the value for these ff boolean properties every time location changes:
                OnPropertyChanged("HasLocationToNorth"); 
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToSouth");

            } 
        }
        public World CurrentWorld { get; set; }

        public bool HasLocationToNorth {
            get
            {
                return CurrentWorld.GetLocation(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
                // checks if GetLocation returns an existing location
            }
        }

        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.GetLocation(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
                // checks if GetLocation returns an existing location
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.GetLocation(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
                // checks if GetLocation returns an existing location
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.GetLocation(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
                // checks if GetLocation returns an existing location
            }
        }

        // to notify the changes in the UI as the location changes
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.GetLocation(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1); // move up
        }

        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.GetLocation(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate); // move left
        }

        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.GetLocation(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate); // move right
        }

        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.GetLocation(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1); // move down
        }
    }
}
