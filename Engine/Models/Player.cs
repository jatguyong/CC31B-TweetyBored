using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        // backing variables
        private string _name;
        private string _characterClass;
        private int _level;
        private int _coin;
        private int _hitPoints;
        private int _experiencePoints;

        public ObservableCollection<GameItem> Inventory { get; set; }
        // this automatically handles all the notifications
        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
        }

        // properties
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
                // call this method whenever a property is changed
            }
        }
        public string CharacterClass
        {
            get
            {
                return _characterClass;
            }
            set
            {
                _characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            }
        }
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level  = value;
                OnPropertyChanged(nameof(Level));
            }
        }
        public int Coin {
            get
            {
                return _coin;
            }
            set
            {
                _coin = value;
                // set the value of _coin to whatever value is passed
                OnPropertyChanged(nameof(Coin));
                // this notifies that the Coin value has changed and refreshes the value of Coin in the UI
            }
        }
        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                _hitPoints  = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int ExperiencePoints
        {
            get
            {
                return _experiencePoints;
            }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }
    }
}
