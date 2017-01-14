using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFAPP.XFControls
{
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void Sw1_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Toggled", "value is: " + Sw1.IsToggled, "OK");
        }
        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new MainPage();
            return true;
        }
    }
}
