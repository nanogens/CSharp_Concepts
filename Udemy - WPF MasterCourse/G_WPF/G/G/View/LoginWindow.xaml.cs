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
using System.Windows.Shapes;

namespace G.View
{
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		public LoginWindow()
		{
			InitializeComponent();
		}

		private void haveAcccountButton_Click(object sender, RoutedEventArgs e)
		{
			registerStackPanel.Visibility = Visibility.Collapsed;
			loginStackPanel.Visibility = Visibility.Visible;
		}

		private void noAccountButton_Click(object sender, RoutedEventArgs e)
		{
			registerStackPanel.Visibility = Visibility.Visible;
			loginStackPanel.Visibility = Visibility.Collapsed;
		}
	}
}
