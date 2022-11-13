using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace All_Access_Project
{
    public partial class App : Application
    {
        private static SQLliteHelper db;

        public static SQLliteHelper All_Access_Database
        {
            get
            {
                if (db == null)
                {
                    db = new SQLliteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "MyStore.db3"));
                }
                return db;
                
            }
        }
        public App()
        {
            InitializeComponent();

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
