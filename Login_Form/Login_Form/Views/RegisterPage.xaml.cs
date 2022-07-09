using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_Form.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login_Form
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        RegisterController rs;
        public RegisterPage()
        {
            InitializeComponent();
            rs = new RegisterController();
            // set Binding
            BindingContext = rs;
        }

        //private void btn_signup_Clicked(object sender, EventArgs e)
        //{
        //    string email = txt_email.Text;
        //    string password = txt_password.Text;
        //    string confirmPassword = txt_confirm.Text;

        //    txt_email.BackgroundColor = Color.White;
        //    txt_password.BackgroundColor = Color.White;
        //    txt_confirm.BackgroundColor = Color.White;

        //    if (String.IsNullOrEmpty(email))
        //    {
        //        txt_email.BackgroundColor = Color.Red;
        //        DisplayAlert("Warning", "Type Email", "OK");
        //        return;
        //    }

        //    else if (String.IsNullOrEmpty(password))
        //    {
        //        txt_password.BackgroundColor = Color.Red;
        //        DisplayAlert("Warning", "Type Password", "OK");
        //        return;
        //    }

        //    else if (String.IsNullOrEmpty(confirmPassword))
        //    {
        //        txt_confirm.BackgroundColor = Color.Red;
        //        DisplayAlert("Warning", "Type Confirm Password", "OK");
        //        return;
        //    }

        //    else if (password != confirmPassword)
        //    {
        //        DisplayAlert("Warning", "Password not match!", "OK");
        //    }

        //    else
        //    {
        //        DisplayAlert("Warning", "Successful registration!", "OK");
        //    }
        //}
    }
}