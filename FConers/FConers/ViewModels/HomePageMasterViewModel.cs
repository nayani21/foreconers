using FConers.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FConers.ViewModels
{
  public   class HomePageMasterViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<HomePageMenuItem> MenuItems { get; set; }
        public ICommand LogOutCommand { get; set; }
        public void ListView_ItemSelected(HomePageMenuItem sender)
        {

            if (sender != null && sender.Id == 0)
                App.Current.MainPage = new MainPage();

            else if (sender != null && sender.Id == 1)
            {
                App.Current.MainPage = new HomePage();
            }
            else
            {
                App.Current.MainPage = new HomePage();
            }

        }

        public HomePageMasterViewModel()
        {
            LogOutCommand = new Command<HomePageMenuItem>(ListView_ItemSelected);
            MenuItems = new ObservableCollection<HomePageMenuItem>(new[]
            {
                    new HomePageMenuItem { Id = 0, Title = "SignOut" },
                    new HomePageMenuItem { Id = 1, Title = "MyTransanction" },

                });

        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;
            else
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
        #endregion


    }
}

