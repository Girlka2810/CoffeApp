using System;
using System.ComponentModel;
using CoffeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPageVM ViewModel { get; set; }
        public AboutPage()
        {
            InitializeComponent();
            ViewModel = new AboutPageVM();
            this.BindingContext =  ViewModel;
        }
    }
}