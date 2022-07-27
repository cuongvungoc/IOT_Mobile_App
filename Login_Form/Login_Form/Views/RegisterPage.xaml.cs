using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_Form.Models;
using Login_Form.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_Form
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        UserRepoViewModel reposity = new UserRepoViewModel();
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void btn_signup_Clicked(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;
            string confirm = TxtConfirm.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Warning", "Please Enter", "Cancel");
            }
            else if (password != confirm)
            {
                await DisplayAlert("Warning", "Password and Confirm Password are not match", "Cancel");
            }
            else
            {
                DeviceModel device = new DeviceModel();
                device.Name = email;
                device.Status = password;
                Task<bool> isSaved = reposity.SaveDevice(device);
                //Users user = new Users();
                //user.Email = email;
                //user.Password = password;
                //Task<bool> isSaved = reposity.Save(user);
                if (await isSaved)
                {
                    await DisplayAlert("Infomation", "User has been saved", "OK");
                }
                else
                {
                    await DisplayAlert("Error", "User has not been saved", "OK");
                }
            }
        }
    }
}