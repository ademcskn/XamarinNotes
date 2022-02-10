using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinMobile.Models
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public ContactViewModel()
        {
            LaunchWebSiteCommand = new Command(async () => await LaunchWebSite());
            SaveContactCommand = new Command(async () => await SaveContact());
        }

        private string _name;
        private long _phone;
        private string _website;
        private bool _favorite;
        private bool _isBusy;
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand LaunchWebSiteCommand { get; set; }
        public ICommand SaveContactCommand { get; set; }

        async Task LaunchWebSite()
        {
            try
            {
                await Browser.OpenAsync(new Uri(_website), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception)
            {

                throw;
            }
        }

        async Task SaveContact()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
            await Application.Current.MainPage.DisplayAlert("Save Contact", "Kayıt Eklendi", "Cancel");
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }
        public long Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }
        public bool Favorite
        {
            get { return _favorite; }
            set
            {
                _favorite = value;
                OnPropertyChanged(nameof(Favorite));
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }
        public string DisplayMessage { get { return $"{Name} {(Favorite ? "is" : "is not ")} your friend."; } }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public string WebSite
        {
            get { return _website; }
            set
            {
                _website = value;
                OnPropertyChanged(nameof(WebSite));
            }
        }

    }
}

