using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            RegForm f2 = new RegForm();
            f2.ShowDialog(); // Avaa Rekisteröimis Formin
            this.Close();
        }

        private void LogBut_Click(object sender, RoutedEventArgs e)
        {
            LogForm f1 = new LogForm();
            f1.ShowDialog(); // Avaa Kirjautumis Formin
            this.Close();
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
