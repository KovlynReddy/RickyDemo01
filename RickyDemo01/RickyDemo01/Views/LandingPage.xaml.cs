using Microsoft.Practices.ServiceLocation;
using RickyDemo01.Database;
using RickyDemo01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RickyDemo01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public IRickyRipository _repo { get; set; }


        public LandingPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance<ViewUsersViewModel>();
        }
        
       
    }
}