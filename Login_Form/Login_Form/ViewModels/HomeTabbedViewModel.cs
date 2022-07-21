﻿using Login_Form.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Login_Form.Views;

namespace Login_Form.ViewModels
{
    class HomeTabbedViewModel
    {
        public INavigation NavigationPage { get; set; }
        public string WelcomeName { get; set; } = "Cuong";
        public ObservableCollection<DeviceModel> DeviceData { get; set; } = new ObservableCollection<DeviceModel>
        {
            new DeviceModel
            {
                Image="livingroom.png",
                RoomName="LivingRoom",
                NumberDevice="5",
                BgColor="#F2D7D9",
            },
            new DeviceModel
            {
                Image="kitchen.png",
                RoomName="Kitchen",
                NumberDevice="5",
                BgColor="#9ADCFF",
            },
            new DeviceModel
            {
                Image="bathroom.png",
                RoomName="Bathroom",
                NumberDevice="6",
                BgColor="#A267AC"
            },
            new DeviceModel
            {
                Image="bedroom.png",
                RoomName="BedRoom",
                NumberDevice="4",
                BgColor="#99FEFF"
            },
            new DeviceModel
            {
                Image="bedroom.png",
                RoomName="Office",
                NumberDevice="4",
                BgColor="#94DAFF"
                
            },
        };
        public ICommand SelectItemCommand { get; set; }
        public HomeTabbedViewModel()
        {
            SelectItemCommand = new Command((obj) => SelectItem(obj));
        }

        private void SelectItem(object obj)
        {
            if (obj != null)
            {
                var data = (DeviceModel)obj;
                NavigationPage.PushAsync(new DetailPage(data));
            }
        }
    }
}
