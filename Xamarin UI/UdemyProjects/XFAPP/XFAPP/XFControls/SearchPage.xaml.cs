using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFAPP.XFControls
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void Bar1_OnSearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Search term are", Bar1.Text, "OK");
        }

        private void Bar1_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            lbl1.Text = Bar1.Text;
        }
    }
}
