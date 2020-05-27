﻿using System;
using PersonalityQuiz.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalityQuiz
{
    public partial class App : Application
    {
        public static LegendListManager LegendListManager { get; private set; }
        public App()
        {
            InitializeComponent();
            LegendListManager = new LegendListManager(new RestService());
            MainPage = new MainPage();
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
