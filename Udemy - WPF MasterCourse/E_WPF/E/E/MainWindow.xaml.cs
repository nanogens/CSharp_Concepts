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

// By writing out OpenFileDialog and clicking on "suggested fixes", we see that we need to add this namespace to our project 
// in order to get OpenFileDialog to work
using Microsoft.Win32;
// For usage of File
using System.IO;
// For HttpClient
using System.Net.Http;
using Newtonsoft.Json;
using E.Classes;

namespace E
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

		// when the button is clicked, open file 
	  // pass the filename to MakePredictionAsync function
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// By writing out OpenFileDialog and clicking on "suggested fixes", we see that we need to add this namespace to our project 
			// in order to get OpenFileDialog to work
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image files (*.png; *.jpg) | *.png;*.jpg;*.jpeg | All files (*.*) | *.*";
			dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			if(dialog.ShowDialog() == true)
			{
				string fileName = dialog.FileName;
				selectedImage.Source = new BitmapImage(new Uri(fileName));

				MakePredictionAsync(fileName);
			}
		}

		// send our picture to microsoft's customvision.ai
		// get back a respose in json format and deserialize it
		// format that deserialized data to display it in a list on the XAML front end
		private async void MakePredictionAsync(string fileName)
		{
			// Load up what we need to send to Microsoft's customvision.ai website.
			// This is found on the website itself under Performance -> Prediction URL
			string url = "https://southcentralus.api.cognitive.microsoft.com/customvision/v2.0/Prediction/3b36fe55-0121-493f-89d2-3ce556e1b404/image?iterationId=7f7a9894-7f63-40f0-9c14-8ddf72d4a317";
			string prediction_key = "4855dea24a4442a2af480d3b5284798b";
			string content_type = "application/octet-stream";
			var file = File.ReadAllBytes(fileName);

			// Now make the request to the website
			// Make an HTTP client to do so.
			// With using, as soon as we leave this block of code, the connection to the client will be closed (which is good because we don't want to keep the connection open)
			using (HttpClient client = new HttpClient())
			{
				// Prediction_key is a custom (not common) header requested by the Prediction API
				client.DefaultRequestHeaders.Add("Prediction-Key", prediction_key);
				// Content_type however is a common header on all HTTP request.  So we don't need to add it because it already exists. 
				// We just create the content that needs to be sent
				using (var content = new ByteArrayContent(file))
				{
					// these are headers in Content
					content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(content_type); // passing in the Content_type requested by the API assigned earlier

					// We are sending a request to which we will get a response
					// We use await which will await the response from the website
					// Since we are using an await method, we need to make the function we are in an async method (i.e. private async MakePredictionAsync() shown above)
					var response = await client.PostAsync(url,content); // PostAsync will perform a post (message) operation to the website
																															// PostAsync is what the website is asking for.  
																															// There are also other methods of sending information - PutAsync() and GetAsync() method.  In the latter we don't need to send any info to the server
																															// Note image we send must be under 4 MB - not sure if this limitation is just for the website or the 
																															// Note the response returns in JSON format.
					var responseString = await response.Content.ReadAsStringAsync();

					// Put a breakpoint here at the closing bracket below.
					// When you load an image, sent it via HTTP with content and the website responds, click on the Magnifying glass on responseString after hovering over that variable
					// You should see a string the website returned (results of the prediction) in Json format.
					// Copy that long Json string and go to www.jsonutils.com and paste it there.
					// Click Submit button on the website and it will generate a C# class/es.
					// Copy those classes.

					// Json deserializes to a CustomVision object.
					// And from there we are simply getting from that object its list of predictions.  We don't really need the other information.
					List<Prediction> predictions = (JsonConvert.DeserializeObject<CustomVision>(responseString)).predictions;

                    predictionsListView.ItemsSource = predictions;

				}
			} // HttpClient will now be closed
		}
	}
}
