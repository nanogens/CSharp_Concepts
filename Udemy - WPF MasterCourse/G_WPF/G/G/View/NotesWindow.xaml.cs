using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
		// using this we will know when a certain speech has been identified by the microphone by the event handler
		// and eventually turning on and off these event handlers to start/stop speech recognition
		SpeechRecognitionEngine recognizer;

		public NotesWindow()
		{
			InitializeComponent();

			#region notes
			// You need to install Language Packs on windows.
			// the code SpeechRecognitionEngine.InstalledRecognizers() throw NullExceptions when you dont have any recognizer installed.
			// See there Add Language Packs to Windows
			// On Windows 10 it's simple: 
			// Press Windows Key; 
			// type "Settings" and press 'Enter'; 
			// select "Time & Language" then "Region & Language"; 
			// on "language" section choose "English" (Or Add); 
			// click in "Options" button and download the "Speech" content.
			#endregion

			/*
			foreach (var x in SpeechRecognitionEngine.InstalledRecognizers())
			{
				Console.Out.WriteLine(x.Name);
			}
			*/
			/*
			var currentCulture = (from r in SpeechRecognitionEngine.InstalledRecognizers() 
													 where r.Culture.Equals(Thread.CurrentThread.CurrentCulture) 
													 select r).FirstOrDefault();
			recognizer = new SpeechRecognitionEngine(currentCulture);
			*/

			//var currentCulture = System.Globalization.CultureInfo.CurrentCulture;
			//recognizer = new SpeechRecognitionEngine();

			//GrammarBuilder builder = new GrammarBuilder();
			//builder.AppendDictation();
			//Grammar grammer = new Grammar(builder);
			//recognizer.LoadGrammar(grammer);
			//recognizer.SetInputToDefaultAudioDevice();

			//recognizer.SpeechRecognized += Recognizer_SpeechRecognized; // Recognizer_SpeechRecognized event handler
		}

		// speech recognizer event handler
		private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			// the text is what we eventually assign to the contentRichTextBox
			string recognizedText = e.Result.Text;
			// not quite as straight forward to assign the string to the contextRichTextBox, but its still quite simple as shown below.
			// puts the speech data we recognized into words (as a paragraph) and adds it to the contentRichTextBox
			contentRichTextBox.Document.Blocks.Add(new Paragraph(new Run(recognizedText)));
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void SpeechButton_Click(object sender, RoutedEventArgs e)
		{
			// the ischecked instead of being a boolean (true/false) could be a nullable boolean (true/false/null)
			// we have casted the nullable boolean that ischecked generates into a boolean.
			bool isButtonEnabled = (sender as ToggleButton).IsChecked ?? false;
			// this is to start and stop the recognition of the speech
			if (isButtonEnabled) // if(isRecognizing == false)
			{
				// start the speech recognition
				recognizer.RecognizeAsync(RecognizeMode.Multiple);
			}
			else
			{
				recognizer.RecognizeAsyncStop();
			}
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
			// the ischecked instead of being a boolean (true/false) could be a nullable boolean (true/false/null)
			// we have casted the nullable boolean that ischecked generates into a boolean.
			bool isButtonEnabled = (sender as ToggleButton).IsChecked ?? false;
			// this is to start and stop the recognition of the speech
			if (isButtonEnabled) // if(isRecognizing == false)
			{
				// the text that needs to be bolded
				contentRichTextBox.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
			}
			else
			{
				// the text that needs to be normal
				contentRichTextBox.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Normal);
			}



		}
	}
}
