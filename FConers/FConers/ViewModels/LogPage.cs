using FConers.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FConers.ViewModels
{
  public   class LogPage:INotifyPropertyChanged
    {
        public String username = String.Empty;
        public string password = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        public LogPage()
        {

            LoginCommand = new Command(log);
        }

        public void log()
        {
            bool result = Auth();
            if (result)
            {
                // App.Current.MainPage = new HomePage();
                App.Current.MainPage = new HomePage();
                // App.Current.MainPage = new MenuPage();
            }
            else
            {
                App.Current.MainPage = new MainPage();
            }

            // string s = UserName;
            //  UserName = "ghsgdh";

            //NavigationPage(new )

        }
        public string UserName
        {
            get { return username; }
            set
            {
                username = value;
                //   OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool Auth()
        {
            if (this.Password.Equals("test", StringComparison.OrdinalIgnoreCase) && this.UserName.Equals("test", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

        public ICommand LoginCommand { get; set; }
    }
}
