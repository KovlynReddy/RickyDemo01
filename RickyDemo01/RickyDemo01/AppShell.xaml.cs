using RickyDemo01.Database;
using RickyDemo01.ViewModels;
using RickyDemo01.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RickyDemo01
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        IRickyRipository repo;
        public AppShell(IRickyRipository db)
        {
            InitializeComponent();

               repo = db;
            DependencyService.RegisterSingleton<IRickyRipository>(db);

            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(LandingPage), typeof(LandingPage));
        }

    }
}
