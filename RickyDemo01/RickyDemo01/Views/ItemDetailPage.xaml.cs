using RickyDemo01.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RickyDemo01.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}