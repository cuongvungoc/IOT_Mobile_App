using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login_Form.Views;

namespace Login_Form
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            MainPage = new NavigationPage(new LoginUI());
            //HomeTabbedPage = new NavigationPage(new HomeTabbedPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
