﻿using kp_deEncode.Core;
using kp_deEncode.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp_deEncode.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public AboutViewModel AboutVM { get; set; }
       

        private object? _currentView;

        public object  CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value; 
                 OnPropertyChanged();
            } 
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            AboutVM = new AboutViewModel();
        

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            { 
                CurrentView = HomeVM;
            });

            AboutViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutVM;
            });
     


        }
    }
}
