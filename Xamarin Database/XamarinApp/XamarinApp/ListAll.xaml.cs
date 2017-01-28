using System;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class ListAll : ContentPage
    {
        public ListAll()
        {
            DataBind();
            InitializeComponent();
        }

        private void DataBind()
        {
            BindingContext = App.Database.GetMovies();
        }
        private void MovieList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var movie = e.Item as Movie;
            if (e != null)
            {
                DisplayAlert("movie Info", movie.MovieName + " " + movie.ReleaseDate, "OK");
            }
        }

        private async void  BtnDelete_OnClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Delete", "Are you sure you want to delete this item?", "Yes", "No");
            if (answer)
            {
                var bnt = (Button)sender;
                var movie = bnt.CommandParameter as Movie;
                App.Database.DeleteMovie(movie.Id);
                DataBind();
                await DisplayAlert("Success", "Item Deleted successfully", "OK");
            }
        }

        private async void BtnUpdate_OnClicked(object sender, EventArgs e)
        {
            var bnt = (Button)sender;
            var movie = bnt.CommandParameter as Movie;
            EditMovie page = new EditMovie();
            page.BindingContext = movie;
            await Navigation.PushAsync(page);
        }
    }
}
