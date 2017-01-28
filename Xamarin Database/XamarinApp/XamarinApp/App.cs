using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinApp.DB;

namespace XamarinApp
{
    public class App : Application
    {
        public static MovieDatabase database;
        public static MovieDatabase Database => database ?? (database = new MovieDatabase());
        public App()
        {
            MainPage = new NavigationPage(new MoviePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
