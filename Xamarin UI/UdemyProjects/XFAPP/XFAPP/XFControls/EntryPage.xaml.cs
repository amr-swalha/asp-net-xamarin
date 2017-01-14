using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFAPP.XFControls
{
    public partial class EntryPage : ContentPage
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            DisplayAlert("Complete", "You have completed the work", "OK");
        }

        private void EntryEvent_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            lblResult.Text = EntryEvent.Text;
        }

        private void EntryEvent_OnUnfocused(object sender, FocusEventArgs e)
        {
            DisplayAlert("Complete", "You have left the text", "OK");
        }
        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new MainPage();
            return true;
        }
    }
}
