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

// to access WeatherAPI
using F.ViewModel;

namespace F.View
{
	/// <summary>
	/// Interaction logic for WeatherWindow.xaml
	/// </summary>
	public partial class WeatherWindow : Window
	{
		public WeatherWindow()
		{
			InitializeComponent();

			// we need to make this method an Awaited method.
			// we cannot do that here in the constructor. 
			// we need to do it outside the constructor.
			// the function which does it will be defined as an async method
			GetWeather();
		}

		private async void GetWeather()
		{
			var weather = await WeatherAPI.GetWeatherInformationAsync("Txz"); 
		}
	}
}
