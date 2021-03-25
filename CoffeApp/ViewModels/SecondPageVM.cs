using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CoffeApp.Annotations;
using CoffeApp.Models;
using CoffeApp.Services;
using Xamarin.Forms;

namespace CoffeApp.ViewModels
{
    public class SecondPageVM: INotifyPropertyChanged
    {
        public ObservableCollection<SpaceHeroModel> Heroes { get=> _heroes;
            set
            {
                _heroes = value;
                OnPropertyChanged(nameof(Heroes));
            }
            
        }
        private ObservableCollection<SpaceHeroModel> _heroes;
        private CharactersModel _charactersModel;
        private readonly SpaceHeroService _service;
        public ICommand Command { get; set; }
        public CharactersModel CharactersModel
        {
            get=> _charactersModel;
            set
            {
                _charactersModel = value;
                OnPropertyChanged(nameof(CharactersModel));
            }
        }
       public  SecondPageVM()
       {
           Heroes = new ObservableCollection<SpaceHeroModel>();
            _service = new SpaceHeroService();
            Command = new Command(ShowCharacters);
       }

       public async void ShowCharacters()
       {
          var modelInfo= await _service.GetAllSpaceHero();
          foreach (var character in modelInfo.Results)
          {
             Heroes.Add(new SpaceHeroModel()
              {
                  Gender = character.Gender, Height = character.Height, Name = character.Name
              }
              );
          }
       }

       public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       }
    }
    
}