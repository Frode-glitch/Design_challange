using Designchallenge.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Policy;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

public class RestService
{
    HttpClient _client;

    //public List<Deals> Deals { get; private set; }

    public RestService()
    {
        _client = new HttpClient();
    }
    public async Task<Deal> RefreshDataAsync(int id)
    {
        Deal deal = new Deal();

        string Url = $"http://192.168.153.172/?api=123456789&deal={id}";

        Uri uri = new Uri(Url);
        try
        {
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                deal = JsonConvert.DeserializeObject<Deal>(content);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(@"\tERROR {0}", ex.Message);
        }
        Console.WriteLine(deal);
        return deal;
        
    }

    public async Task<List<Deal>> RefreshDataAsync()
    {
        List<Deal> deal = new List<Deal>();

        string Url = $"http://192.168.153.172/?api=123456789&deal";

        Uri uri = new Uri(Url);
        try
        {
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                // deal = JsonSerializer.Deserialize<Deal>(content);

                deal = JsonConvert.DeserializeObject<List<Deal>>(content);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(@"\tERROR {0}", ex.Message);
        }
        Console.WriteLine(deal);
        return deal;

    }

    public async Task<User> RefreshDataAsync(int id)
    {
        User user = new User();

        string Url = $"http://192.168.153.172/?api=123456789&user={id}";

        Uri uri = new Uri(Url);
        try
        {
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                user = JsonConvert.DeserializeObject<User>(content);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(@"\tERROR {0}", ex.Message);
        }
        Console.WriteLine(user);
        return user;

    }

    //dit moet vgm gefixt worden in de backend
    public async Task<Parked> RefreshDataAsync()
    {
        Parked parked = new Parked();

        string Url = $"http://192.168.153.172/?api=123456789&parked";

        Uri uri = new Uri(Url);
        try
        {
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                parked = JsonConvert.DeserializeObject<Parked>(content);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(@"\tERROR {0}", ex.Message);
        }
        Console.WriteLine(parked);
        return parked;

    }
}