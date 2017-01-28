using System;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainHomePage : ContentPage
    {
        public MainHomePage()
        {
            /*BindingContext = APICaller<Movie>.GetById(1, "movie");*/
            InitializeComponent();
        }
        public void btnSearch_Click(object o,EventArgs args)
        {
            /*BindingContext = APICaller<Movie>.GetById(int.Parse(movieId.Text), "movie");*/
        }
    }
}
