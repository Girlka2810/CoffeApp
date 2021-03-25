using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CoffeApp.Annotations;
using CoffeApp.Services;

namespace CoffeApp.Models
{
    public class CharactersModel:INotifyPropertyChanged
    {
        private ObservableCollection<SpaceHeroModel> _characters;
        public ObservableCollection<SpaceHeroModel> Characters 
        { 
            get=> _characters;
            set
            {
                _characters = value;
                OnPropertyChanged(nameof(Characters));
            } 
        }

        public CharactersModel()
        {
            Characters = new ObservableCollection<SpaceHeroModel>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}