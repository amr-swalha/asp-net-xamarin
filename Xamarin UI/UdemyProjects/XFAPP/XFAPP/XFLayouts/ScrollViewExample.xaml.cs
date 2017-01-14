using Xamarin.Forms;

namespace XFAPP.XFLayouts
{
    public partial class ScrollViewExample : ContentPage
    {
        public ScrollViewExample()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayAlert("You appeared", "This page is up", "OK");
        }
        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new MainPage();
            return true;
            //return base.OnBackButtonPressed();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            DisplayAlert("You disappeared", "This page is gone", "OK");
        }
    }
}
