using Login_Form.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Login_Form.ViewModels
{
    class HomeTabbedViewModel
    {
        public string WelcomeName { get; set; } = "Cuong";
        public ObservableCollection<DeviceModel> DeviceData { get; set; } = new ObservableCollection<DeviceModel>
        {
            new DeviceModel
            {
                Image="livingroom.png",
                RoomName="LivingRoom",
                NumberDevice="5",
            },
            new DeviceModel
            {
                Image="kitchen.png",
                RoomName="Kitchen",
                NumberDevice="5",
            },
            new DeviceModel
            {
                Image="bathroom.png",
                RoomName="Bathroom",
                NumberDevice="6",
            },
            new DeviceModel
            {
                Image="bedroom.png",
                RoomName="BedRoom",
                NumberDevice="4",
            },
        };
        public HomeTabbedViewModel()
        {

        }
    }
}
