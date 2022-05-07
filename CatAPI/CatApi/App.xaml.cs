using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DedApi.Services;
using DedApi.Views;

namespace DedApi
{
    public partial class App : Application
    {
        public static RequestManager RequestManager { get; private set; }
        public App()
        {
            InitializeComponent();
            RequestManager = new RequestManager(new RestService());
            MainPage = new NavigationPage(new CatsListPage());
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
