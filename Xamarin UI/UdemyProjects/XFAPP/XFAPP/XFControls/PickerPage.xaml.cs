using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFAPP.XFControls
{
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
            Picker1.Items.Add("test 1");
            Picker1.Items.Add("test 2");
            Picker2.Items.Add("First Item");
            Picker2.Items.Add("Second Item");
            Picker2.Items.Add("Third Item");
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new MainPage();
            return true;
        }

        private void Picker2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAlert("Selected Item",
                "is: " + Picker2.Items[Picker2.SelectedIndex],
                "OK");
        }

        private void BntGet_OnClicked(object sender, EventArgs e)
        {
            if (Picker2.SelectedIndex == -1)
            {
                DisplayAlert("No value", "Please select a value", "OK");
            }
            else
            {
                Secondlbl.Text = "The value is: " + Picker2.Items[Picker2.SelectedIndex];
            }
            
        }

        private void BntSet_OnClicked(object sender, EventArgs e)
        {
            Picker2.SelectedIndex = 2;
        }
    }
}
