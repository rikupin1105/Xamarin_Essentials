﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Essentials.Views;

namespace Xamarin_Essentials
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
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
