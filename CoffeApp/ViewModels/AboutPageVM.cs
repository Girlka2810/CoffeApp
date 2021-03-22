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
        private List<PreparationInfo> _preparationInfoList;
        public List<PreparationInfo> PreparationInfoList
        {
            get => _preparationInfoList;
            set
            {
                _preparationInfoList = value;
                NotifyPropertyChanged(nameof(PreparationInfoList));
            }
        }
       public ICommand Command { get; set; }
       public ICommand CommandNext { get; set; }
       public ICommand CommandPrevious { get; set; }

        private int _index;
        public CoffeeModel CoffeeModel
        {
            get => _coffeeModel;
            
            set
            {
                _coffeeModel = value;
                NotifyPropertyChanged(nameof(CoffeeModel));
            }
        }

       
        public AboutPageVM()
        {
            _coffeeModel = new CoffeeModel() { Name = "Jungle Espresso", ImageSourse = "coffeCup.jpg", Price = "2.20$", Producer= "by UXDivers" };
            _coffeeModelList = new List<CoffeeModel>();
            _coffeeModelList.Add(_coffeeModel);
            _coffeeModelList.Add(new CoffeeModel() { Name = "Cappuchino", ImageSourse = "CappuchinoCup.jpg", Price = "3.10$", Producer = "by UXDivers" });
            _coffeeModelList.Add(new CoffeeModel() { Name = "Latte", ImageSourse = "LatteCup.jpg", Price = "4.75$", Producer = "by UXDivers" });
            _index = 0;
            Command = new Command(NextCoffee);
            CommandNext = new Command(NextCoffee);
            CommandPrevious = new Command(PreviousCoffee);
            PreparationInfoList = new List<PreparationInfo>()
            {
                new PreparationInfo() {IconSourse = "intensity.png", Name = "Intensity", ButtonText = "Strong"},
                new PreparationInfo() {IconSourse = "acidity.png", Name = "Acidity", ButtonText = "Sharp"},
                new PreparationInfo() {IconSourse = "preparation.png", Name = "Preparation", ButtonText = "8 minutes"},
                new PreparationInfo() {IconSourse = "size.png", Name = "Size", ButtonText = "Small"}
            };
        }

        private void NextCoffee ()
        {
            if (_index >=  _coffeeModelList.Count-1)
            {
                _index = 0;   
            }
            else
            { _index++; }
            CoffeeModel = _coffeeModelList[_index];
        }
        private void PreviousCoffee ()
        {
            if (_index >  0)
            {
                _index--;   
            }
            else
            { _index=_coffeeModelList.Count-1; }
            CoffeeModel = _coffeeModelList[_index];
        }

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
