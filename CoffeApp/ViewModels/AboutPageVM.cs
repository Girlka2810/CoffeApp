using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CoffeApp.Models;
using Xamarin.Forms;

namespace CoffeApp.ViewModels
{
    public class AboutPageVM : INotifyPropertyChanged
    {
        private CoffeeModel _coffeeModel;
        private List <CoffeeModel> _coffeeModelList;
       public ICommand Command { get; set; }
        private int _index;
        public CoffeeModel CoffeeModel
        {
            get
            {
                return _coffeeModel;
            }
            set
            {
                _coffeeModel = value;
                NotifyPropertyChanged(nameof(CoffeeModel));
            }
        }

       
        public AboutPageVM()
        {
            _coffeeModel = new CoffeeModel() { Name = "Jungle Espresso", ImageSourse = "coffeCup.jpg", Price = "2.10$", Producer= "by UXDivers" };
            _coffeeModelList = new List<CoffeeModel>();
            _coffeeModelList.Add(_coffeeModel);
            _coffeeModelList.Add(new CoffeeModel() { Name = "Cappuchino", ImageSourse = "CappuchinoCup.jpg", Price = "3.10$", Producer = "by UXDivers" });
            _coffeeModelList.Add(new CoffeeModel() { Name = "Latte", ImageSourse = "LatteCup.jpg", Price = "4.75$", Producer = "by UXDivers" });
            _index = 0;
            Command = new Command(NextCoffee);
        }

        public void NextCoffee ()
        {
            if (_index >=  _coffeeModelList.Count-1)
            {
                _index = 0;   
            }
            else
            { _index++; }
            _coffeeModel = _coffeeModelList[_index];
        }



        //private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        //{
        //   PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        // }

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
