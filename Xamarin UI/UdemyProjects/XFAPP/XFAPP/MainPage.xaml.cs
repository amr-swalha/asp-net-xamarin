using System;
using Xamarin.Forms;
using XFAPP.XFControls;
using XFAPP.XFLayouts;

namespace XFAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BntStack_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new StackLayoutExample();
        }

        private void BntScroll_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ScrollViewExample();
        }

        private void BntCoded_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CodedPage();
        }

        private void BntEntry_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EntryPage();
        }

        private void BntPicker_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PickerPage();
        }

        private void BntSwitch_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SwitchPage();
        }

        private void BntEditor_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EditorPage();
        }

        private void BntSearch_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SearchPage();
        }
    }
}
