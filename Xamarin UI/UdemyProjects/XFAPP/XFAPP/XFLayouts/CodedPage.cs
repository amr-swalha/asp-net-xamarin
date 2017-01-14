using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XFAPP.XFLayouts
{
    public class CodedPage : ContentPage
    {
        public CodedPage()
        {
            this.BackgroundColor = Color.Red;
            BoxView box = new BoxView();
            box.Color = Color.Green;
            box.HeightRequest = 500;
            ScrollView scrollView = new ScrollView();
            scrollView.Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Top" },
                    box,
                    new Label { Text = "Bottom" }
                    
                }
            };
            Content = scrollView;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayAlert("You appeared", "This page is up", "OK");
        }
    }
}
