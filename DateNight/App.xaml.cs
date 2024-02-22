using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DateNight.models;

namespace DateNight
{
    public partial class App : Application
    {
        //create instance
        public static DateCalculator dateCalc;

        public App()
        {
            InitializeComponent();
            //instanciate instance 
            dateCalc = new DateCalculator();
            MainPage = new TabController();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
