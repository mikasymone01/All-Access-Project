using All_Access_Project.Services;
using All_Access_Project.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace All_Access_Project
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
