using System.Windows;

namespace Eläinklinikka
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LogForm l1 = new LogForm();
            this.Hide();
            l1.ShowDialog();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RegForm r1 = new RegForm();
            this.Hide();
            r1.ShowDialog();
            this.Close();
        }
    }
}
