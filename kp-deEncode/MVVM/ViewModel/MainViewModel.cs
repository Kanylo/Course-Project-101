using kp_deEncode.Core;
using System.ComponentModel;

namespace kp_deEncode.MVVM.ViewModel
{

    class MainViewModel : ObservableObject, INotifyPropertyChanged
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutViewCommand { get; set; }
        public RelayCommand EncodeViewCommand { get; set; }
        public RelayCommand DecodeViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public AboutViewModel AboutVM { get; set; }
        public EncodeViewModel EncodeVM { get; set; }
        public DecodeViewModel DecodeVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            AboutVM = new AboutViewModel();
            EncodeVM = new EncodeViewModel();
            DecodeVM = new DecodeViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            AboutViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutVM;
            });
            EncodeViewCommand = new RelayCommand(o =>
            {
                CurrentView = EncodeVM;
            });
            DecodeViewCommand = new RelayCommand(o =>
            {
                CurrentView = DecodeVM;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ScrollDown()
        {
            CurrentView = DecodeVM;
        }
    }
}
