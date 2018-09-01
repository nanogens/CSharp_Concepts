using G.ViewModel;
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

			LoginVM vm = new LoginVM();
			// effectively the same thing as using DataContext = "{StaticResource login}" ??
			// this is setting the data context from c# instead
			containerGrid.DataContext = vm;
			// now that we have the vm in here, we can effectively create an event handler in here
			vm.HasLoggedIn += Vm_HasLoggedIn;
		}

		private void Vm_HasLoggedIn(object sender, EventArgs e)
		{
			this.Close(); // we can close here because the user has already logged in or registered
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
