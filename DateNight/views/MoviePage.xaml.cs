using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight.views
{
    public partial class MoviePage : ContentPage
    {
        public MoviePage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dateCalc.MovieCost = txtMovie.Text;
        }
    }
}
