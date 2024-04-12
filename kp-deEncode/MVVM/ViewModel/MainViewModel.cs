using kp_deEncode.Core;
using System.ComponentModel;
using Prism.Mvvm;
using System.Windows.Input;
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
        public ICommand EncodeCommand { get; private set; }
        public ICommand ExitCommand { get; set; }

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
            EncodeCommand = new RelayCommand(Encode);

            HomeVM = new HomeViewModel();
            AboutVM = new AboutViewModel();
            EncodeVM = new EncodeViewModel();
            DecodeVM = new DecodeViewModel();
            ExitCommand = new RelayCommand(Exit);

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

        private void Encode(object obj)
        {
            if (CurrentView is EncodeViewModel encodeVM)
            {
                encodeVM.Output = Solving.EncodeToBase64(encodeVM.Input);
            }
        }
        private void Decode(object obj)
        {
            if (CurrentView is DecodeViewModel decodeVM)
            {
                decodeVM.Output = Solving.DecodeFromBase64(decodeVM.Input);
            }
        }
        private void Exit(object obj)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
