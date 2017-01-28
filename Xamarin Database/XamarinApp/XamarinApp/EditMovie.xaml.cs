using System;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class EditMovie : ContentPage
    {
        public EditMovie()
        {

            InitializeComponent();
        }

        private async void BtnUpdate_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Movie movie = new Movie();
                movie.MovieName = movieName.Text;
                movie.ReleaseDate = movieRelease.Date;
                movie.Length = int.Parse(movieLength.Text);
                movie.Id = int.Parse(lblId.Text);
                App.Database.SaveContact(movie);
                DisplayAlert("Saved", "Value updated succesfully", "Great!");
                await Navigation.PushAsync(new ListAll());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message + " " + ex.StackTrace, "Yes");
            }
        }
    }
}
