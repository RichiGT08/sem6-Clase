﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sem6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new insertar();
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
