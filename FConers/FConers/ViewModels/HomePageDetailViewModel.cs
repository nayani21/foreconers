using FConers.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FConers.ViewModels
{
   public  class HomePageDetailViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Category> BookCategories { get; private set; }
        public ICommand SelectCategoryCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public HomePageDetailViewModel()
        {
            BookCategories = new ObservableCollection<Category>(CategoryFactory.GetCategories());
         //   SelectCategoryCommand = new Command<Category>ListView_CategorySelected();

        }

        public void ListView_CategorySelected(Category sender)
        {

            //if (sender != null && sender.Id == 1)
            //    App.Current.MainPage = new CategorizedView();

            //else
            //{
            //    App.Current.MainPage = new HomePage();
            //}


        }

    }
}
