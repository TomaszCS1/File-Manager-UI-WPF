using System;
using System.Collections.Generic;
using System.Text;
using Dateien_Umbenennen.Core;


namespace Dateien_Umbenennen.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public HomeViewModel HomeVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            {_currentView = value;
             OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            CurrentView = HomeVm;

        }
    }
}
