using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        // backing variables
        private string _name;
        private string _characterClass;
        private int _level;
        private int _coin;
        private int _hitPoints;
        private int _experiencePoints;

        // properties
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
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
                OnPropertyChanged("CharacterClass");
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
                OnPropertyChanged("Level");
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
                // set the valie of _coin to whatever value is passed
                OnPropertyChanged("Coin");
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
                OnPropertyChanged("HitPoints");
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
                OnPropertyChanged("ExperiencePoints");
            }
        }




        public event PropertyChangedEventHandler? PropertyChanged;
        // whenever an event occurs, this event is triggered

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            // if this method is called, invoke the OnPropertyChanged event handler
            // to change the corresponding value of the passed propertyName in the UI
        }
    }
}
