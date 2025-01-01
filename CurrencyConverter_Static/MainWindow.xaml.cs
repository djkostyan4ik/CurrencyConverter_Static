using System.Windows;

namespace CurrencyConverter_Static
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblCurrency.Content = "Hello World";
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            lblCurrency.Content = "";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

        }
    }
}
