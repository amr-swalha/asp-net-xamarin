using System;
using Xamarin.Forms;

namespace XamarinApp
{
    [ContentProperty("Home")]
    public partial class MoviePage : ContentPage
    {
        public MoviePage()
        {
            InitializeComponent();
        }
        public void btnAdd_Click(object o, EventArgs args)
        {
            try
            {
                Movie movie = new Movie();
                movie.MovieName = movieName.Text;
                movie.ReleaseDate = movieRelease.Date;
                movie.Length = int.Parse(movieLength.Text);
                App.Database.SaveContact(movie);
                DisplayAlert("Saved", "Value saved succesfully", "Great!");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message + " " + ex.StackTrace, "Yes");
            }
        }
        public void btnView_Click(object o, EventArgs args)
        {
            Navigation.PushAsync(new ListAll());
        }


    }
}
