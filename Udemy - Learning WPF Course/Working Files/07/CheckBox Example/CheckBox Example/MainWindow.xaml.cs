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

namespace CheckBox_Example
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

        private void cbChoc_Checked(object sender, RoutedEventArgs e)
        {
            label1.Content = "Extra chocolate selected";
        }

        private void cbChoc_Unchecked(object sender, RoutedEventArgs e)
        {
            label1.Content = " ";
        }

        private void cbSugar_Checked(object sender, RoutedEventArgs e)
        {
            label2.Content = "No sugar has been selected...";
        }

        private void cbSugar_Unchecked(object sender, RoutedEventArgs e)
        {
            label2.Content = " ";
        }
    }
}
