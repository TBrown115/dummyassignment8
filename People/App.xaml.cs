using People.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Xamarin.Forms;

namespace People
{
    public partial class App : Application
    {
        string dbPath => FileAccessHelper.GetLocalFilePath("tshirt.db3");

        public static TShirtRepository PersonRepo { get; private set; }
        public App()
        {
            InitializeComponent();

            PersonRepo = new TShirtRepository(dbPath);
            var tshirt = new NavigationPage(new TShirtPage());
            

            MainPage = tshirt;
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
