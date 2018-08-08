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
	/// Interaction logic for NotesWindow.xaml
	/// </summary>
	public partial class NotesWindow : Window
	{
		public NotesWindow()
		{
			InitializeComponent();
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void contentRichTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			// this is how we can access the text that is inside the textbox
			int ammountCharacters = (new TextRange(contentRichTextBox.Document.ContentStart, contentRichTextBox.Document.ContentEnd)).Text.Length;
			// now that we have the ammount of characters, let us now set the text in the statusTextBlock equal to the amount of characters we received above
			statusTextBlock.Text = $"Document length: {ammountCharacters} characters";
		}

		private void boldButton_Click(object sender, RoutedEventArgs e)
		{
			// the text that needs to be bolded
			contentRichTextBox.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
		}
	}
}
