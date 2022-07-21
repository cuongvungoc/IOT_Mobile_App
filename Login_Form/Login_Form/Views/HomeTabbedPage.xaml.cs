using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login_Form.Models;
using Login_Form.ViewModels;

namespace Login_Form.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : ContentPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();
            var vm = (HomeTabbedViewModel)BindingContext;
            if (vm != null)
                vm.NavigationPage = Navigation;
        }
    }
}