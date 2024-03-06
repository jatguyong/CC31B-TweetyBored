using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BaseNotificationClass : INotifyPropertyChanged
    {
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
