using System;
using JokeDB.Data;
using JokeDB.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JokeDB
{
    public partial class App : Application
    {

        static JokeItemDatabase database;

        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new JokeListPage());
            MainPage = nav;
        }

        public static JokeItemDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new JokeItemDatabase();
                }
                return database;
            }
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
