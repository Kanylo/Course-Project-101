using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kp_deEncode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // do something with inputBox.Text
        }

        private void SelectBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // do something with selectBox.SelectedItem
        }

        private void InputBox_Copy2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}