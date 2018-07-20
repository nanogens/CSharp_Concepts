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
		//public const string BASE_URL = "http://dataservice.accuweather.com/currentconditions/v1/{0}?apikey={1}&details=true";
		public const string CURRENTCONDITIONS_URL = "http://dataservice.accuweather.com/currentconditions/v1/{0}?apikey={1}";

		public const string CITYFRAGMENT_KEY = "Toronto";
		// 0 is your api key
		// 1 is you city string (fragment)
		public const string AUTOCOMPLETE_URL = "http://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey={1}&q={0}";


		// since this is now of type async, we will set it to be a Task<>
		// what this means is that by default, the getweatherinformationasync() will be a task
		// this is now an Asynchronous method (hence we name it ...Async()

		// by adding the word Task<>, if nothing is awaited, the type is going to be Task<Accuweather>
		// if something is awaited, it will be of type AccuWeather
		public static async Task<CurrentConditions> GetWeatherInformationAsync(string q)
		{
			
			// AUTOCOMPLETE ---------------------------------------------------------
			AutoComplete cities = new AutoComplete();
			var data_city = new List<AutoComplete>();
			string url_autocomplete = string.Format(AUTOCOMPLETE_URL, q, API_KEY);
			using (HttpClient client = new HttpClient())
			{
				var response = await client.GetAsync(url_autocomplete);
				string json = await response.Content.ReadAsStringAsync();
				if (json != "[]")
				{
					data_city = JsonConvert.DeserializeObject<List<AutoComplete>>(json);
					cities = data_city[0];
				}
				else
				{
					cities.Key = "55488";  // default to Toronto
				}
			}
			


			// CURRENTCONDITIONS ---------------------------------------------------------
			// to hold the result
			CurrentConditions condition = new CurrentConditions();
			var data_condition = new List<CurrentConditions>();
			// Now we begint he process of constructing the request string to be sent request to AccuWeather
			// format will allow us to change the string with place holders into string with actual values for {0} and {1}
			//string url = string.Format(BASE_URL, LOCATION_KEY, API_KEY);
			string url_condition = string.Format(CURRENTCONDITIONS_URL, cities.Key, API_KEY);

			// now we need to send this url through http client
			using (HttpClient client = new HttpClient())
			{
				// we can get the response by awaiting the GetAsync() method

				// note, without the word await, response will be of type Task<HttpResponseMessage>
				// with the word await, response is of type HttpResponseMessage ... without the Task<>
				// we use here GetAsync() instead of PostAsync() which we used earlier because we don't need to add any header or any body.
				var response = await client.GetAsync(url_condition);
				string json = await response.Content.ReadAsStringAsync();

				// now to convert the Json we got into C# object
				// this method will return a deserialized JSON in the form of an AccuWeather object
				data_condition = JsonConvert.DeserializeObject<List<CurrentConditions>>(json);
				//result = JsonConvert.DeserializeObject<Acc>(json);
				condition = data_condition[0];
				
				// NOTE : We get only 20 requests a day we can execute against the AccuWeather server with our free account.
				// If we happen to use up all 20 requests, we have to wait till the next day.
				// Check to see if json string does not have a proper reply from the server, we may have exceeded our 20 query limit.
			}

			// return back the result we got
			return condition;
		}
	}
}
