using System;
using Xamarin.Forms;

namespace Udemy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnContentView(object sender,EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ContentViewPage());
        }
        private void BtnFrame(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new FramePage());
        }
        private void BtnScroll(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ScrollPage());
        }
        private void BtnGrid(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new GridPage());
        }
    }
}
