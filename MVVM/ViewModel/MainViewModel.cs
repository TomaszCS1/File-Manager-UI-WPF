using System;
using System.Collections.Generic;
using System.Text;
using Dateien_Umbenennen.Core;
using System.Linq.Expressions;
using GalaSoft.MvvmLight.CommandWpf;

namespace Dateien_Umbenennen.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public DiscoveryViewModel DiscoveryVm { get; set; }

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
            DiscoveryVm = new DiscoveryViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => CurrentView = HomeVm;) //33:44
            
        }
    }
}
