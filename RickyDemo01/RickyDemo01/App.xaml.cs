using RickyDemo01.Services;
using RickyDemo01.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using RickyDemo01.Database;
using Microsoft.Practices.Unity;
using Microsoft.Practices.ServiceLocation;

namespace RickyDemo01
{
    public partial class App : Application
    {
        public App(IRickyRipository db)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            UnityContainer _unity = new UnityContainer();

            _unity.RegisterInstance<IRickyRipository>(db);
            _unity.RegisterInstance(typeof(IRickyRipository),db);
            DependencyService.RegisterSingleton<IRickyRipository>(db);// choose one of this 3 dude

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(_unity));

            MainPage = new AppShell(db);
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
