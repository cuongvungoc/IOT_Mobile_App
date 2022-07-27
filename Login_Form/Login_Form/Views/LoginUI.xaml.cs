using Login_Form.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_Form
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        UserRepoViewModel userReposity = new UserRepoViewModel();
        public LoginUI()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //string id = ((ClickedEventArgs)e).Parameter.ToString();
            //var user = await userReposity.GetById(id);
            //if(user == null)
            //{
            //    await DisplayAlert("Warning", "Data not found", "OK");
            //}
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                labelNotice.IsVisible = true;
            }
        }
    }
}