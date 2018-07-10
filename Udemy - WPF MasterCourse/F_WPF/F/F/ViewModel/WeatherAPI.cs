using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for AccuWeather access
using F.Model;
// for HttpClient access
using System.Net.Http;
// for Newtonsoft.Json access (the NuGet package we added)
using Newtonsoft.Json;

#region Notes
// This ViewModel class shifts the code form the code behind into a separate class shown below.
#endregion

namespace F.ViewModel
{
	public class WeatherAPI
	{
		// standard practice to name your const with capital letters
		public const string API_KEY = "c8tGjllI36Z3moa8qBceyl7kcZGVkopG";
		public const string LOCATION_KEY = "328328";
		// 0 is your api key to access AccuWeather (provided in MyApps on the website) 
		// 1 is a location key
		public const string BASE_URL = "http://dataservice.accuweather.com/currentconditions/v1/GET/{0}?apikey={1}";
		

		// since this is now of type async, we will set it to be a Task<>
		// what this means is that by default, the getweatherinformationasync() will be a task
		// this is now an Asynchronous method (hence we name it ...Async()

		// by adding the word Task<>, if nothing is awaited, the type is going to be Task<Accuweather>
		// if something is awaited, it will be of type AccuWeather
		public async Task<AccuWeather> GetWeatherInformationAsync(string cityName)
		{
			// to hold the result
			AccuWeather result = new AccuWeather();

			// Now we begint he process of constructing the request string to be sent request to AccuWeather
			// format will allow us to change the string with place holders into string with actual values for {0} and {1}
			string url = string.Format(BASE_URL, LOCATION_KEY, API_KEY);

			// now we need to send this url through http client
			using (HttpClient client = new HttpClient())
			{
				// we can get the response by awaiting the GetAsync() method

				// note, without the word await, response will be of type Task<HttpResponseMessage>
				// with the word await, response is of type HttpResponseMessage ... without the Task<>
				// we use here GetAsync() instead of PostAsync() which we used earlier because we don't need to add any header or any body.
				var response = await client.GetAsync(url);
				string json = await response.Content.ReadAsStringAsync();

				// now to convert the Json we got into C# object
				// this method will return a deserialized JSON in the form of an AccuWeather object
				result = JsonConvert.DeserializeObject<AccuWeather>(json);
			}

			// return back the result we got
			return result;
		}

	}
}
