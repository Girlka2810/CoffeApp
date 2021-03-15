using System.ComponentModel;
using Xamarin.Forms;
using CoffeApp.ViewModels;

namespace CoffeApp.Views
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