using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// added this in 
using F.Model;

namespace F.ViewModel
{
	public class WeatherVM
	{
		public AccuWeather Weather { get; set; }

		public string query;
		public string Query
		{
			get { return query; }
			set { query = value; }
		}

		// Initialize the Weather properties to our default values (which we set in CurrentConditions class constructor - near the bottom of the class)
		public WeatherVM()
		{
			Weather = new AccuWeather();
			// we need to make this method an Awaited method.
			// we cannot do that here in the constructor. 
			// we need to do it outside the constructor.
			// the function which does it will be defined as an async method
			GetWeather();
		}

		private async void GetWeather()
		{
			var weather = await WeatherAPI.GetWeatherInformationAsync("Toronto");
			Weather.Current_Conditions = weather;
		}
	}
}
