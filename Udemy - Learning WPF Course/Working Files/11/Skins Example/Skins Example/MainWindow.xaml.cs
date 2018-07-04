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
using System.IO;  // ADD THIS TO ACCESS FILESTREAM
using System.Windows.Markup;

namespace Skins_Example
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

        private void chkLooseLayout_Clicked(object sender, RoutedEventArgs e)
        {

            ResourceDictionary skin =
               Application.LoadComponent(new Uri("LooseLayout.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(skin);

           
        }

        private void chkCompactLayout_Clicked(object sender, RoutedEventArgs e)
        {
            ResourceDictionary skin =
               Application.LoadComponent(new Uri("CompactLayout.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(skin);
        }
    }
}
