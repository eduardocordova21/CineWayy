﻿using CineWayy.Views;
using System.Globalization;
using Xamarin.Forms;

namespace CineWayy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
                
            MainPage = new NavigationPage(new Login());
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