using Login_Form.Models;
using Login_Form.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_Form.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        UserRepoViewModel userReposity = new UserRepoViewModel();
        public DetailPage(RoomModel device)
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.White;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Blue;
            var vm = (DetailViewModel)BindingContext;
            if (vm != null)
            {
                vm.Device = device;
            }
        }
        protected override async void OnAppearing()
        {
            var users = await userReposity.GetAll();
            UserListView.ItemsSource = users;
        }
    }
}