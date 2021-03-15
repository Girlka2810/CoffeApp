using System;
using System.Collections.Generic;
using CoffeApp.ViewModels;
using CoffeApp.Views;
using Xamarin.Forms;

namespace CoffeApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
