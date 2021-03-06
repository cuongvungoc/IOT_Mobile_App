using Login_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Login_Form.ViewModels
{
    public class DetailViewModel : INotifyPropertyChanged
    {
        private RoomModel device;
        public string Temperature { get; set; } = "35";

        public RoomModel Device { get => device; set { device = value; NotifyPropertyChanged("Device"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public DetailViewModel()
        {

        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
