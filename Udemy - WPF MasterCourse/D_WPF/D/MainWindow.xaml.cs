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

using D.Classes;

namespace D
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Contact> contacts;

		public MainWindow()
		{
			InitializeComponent();
			ReadDatabase();  // read and display information
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			NewContactWindow newContactWindow = new NewContactWindow();
			// newContactWindow.Show(); // This allows the user to navigate back to the Main Window
			newContactWindow.ShowDialog(); // This prevents the user from navigating back to the Main Window
			ReadDatabase(); // call this method (after the newContactWindow is closed?) so data can be displayed in the main window
											// I think the method is called immediately after ShowDialog() is processed and perhaps even before saveButton_Click() in newContactWindow runs
		}

		void ReadDatabase()
		{
			using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
			{
				conn.CreateTable<Contact>();
				// This is Linq (Language Integrated Query) - to use queries inside the C# language
				// It uses the library System.Linq above
				// adding the orderby orders the list alphabetically before adding it to contacts
				// we cast it to ToList() at the end to make it a list prior to adding it to contacts
				contacts = (conn.Table<Contact>().ToList()).OrderBy(c => c.Name).ToList();

				/*
				// This is the equivalent of OrderBy() method you see above
				// This is Linq.  Its more like C# and less like SQL.
				var variable = from c2 in contacts // this code here is simplified in the OrderBy method by writing c2
											 orderby c2.Name // alphabetical order
				               select c2; // lastly we select c2 
		    */

			}

			if (contacts != null)
			{
				// Populate the list view - this way adds to the list (in duplicate) each time we ReadDatabase (which we don't want)
				// So we use the one line code below which does not duplicate the add procedure
				//foreach (var c in contacts)
				//{
				//    contactsListView.Items.Add(new ListViewItem()
				//    {
				//        Content = c
				//    });
				//}
				contactsListView.ItemsSource = contacts;
			}
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			TextBox searchTextBox = sender as TextBox;

			// This is Linq (Language Integrated Query) - to use queries inside the C# language
			// It uses the library System.Linq above
			// Below, we establish a variable c for contact
			// and that variable is going to be evaluated by its name 
			// what we are going to evaluate is if this Name string whatever is inside of the search text box to get it as a list
			// make sure you make both the search filter and the stuff in the search text box ToLower() or ToUpper() to ignore capital / lower case letters when filtering

			var filteredList = contacts.Where(c => c.Name.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();

			// if you need to create more complex queries, you can use this style instead
			/*
			var filteredList2 = (from c2 in contacts
													where c2.Name.ToLower().Contains(searchTextBox.Text.ToLower())
													orderby c2.Email
													select c2).ToList();
      */
			contactsListView.ItemsSource = filteredList; // change to filteredList2 if you are using the SQL method commented out above
		}
	}
}
