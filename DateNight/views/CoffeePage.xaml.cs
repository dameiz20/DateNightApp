using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight.views
{
    public partial class CoffeePage : ContentPage
    {
        public CoffeePage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dateCalc.CoffeeCost = txtCoffee.Text;
        }

    }
}
