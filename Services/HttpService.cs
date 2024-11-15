using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

public class RestService
{
	HttpClient _client;
	JsonSerializerOptions _serializerOptions;

	public List<Deals> Items { get; private set; }

	public RestService()
	{
		_client = new HttpClient();
		_serializerOptions = new JsonSerializerOptions
		{
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			WriteIndented = true
		};
	}

	public async Task<List<Deals>> RefreshDataAsync()
	{
		Deals = new List<Deals>();

		Uri uri = new Uri(http://192.168.153.172/?api=123456789&deal=1);
		try
		{
			HttpResponseMessage response = await _client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				Deals = JsonSerializer.Deserialize<List<Deals>>(content, _serializerOptions);
			}
		}
		catch (Exception ex)
		{
			Debug.WriteLine(@"\tERROR {0}", ex.Message);
		}

		return Deals;

	}
}