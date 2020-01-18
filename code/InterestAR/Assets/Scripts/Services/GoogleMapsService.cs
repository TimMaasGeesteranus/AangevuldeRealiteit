using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

public class GoogleMapsService
{
    private string _apiKey;
    private string _baseUrl;
    private HttpClient _client;

    public GoogleMapsService()
    {
        _apiKey = "AIzaSyDWnKL07Y0zk_IHGypBUiUF2Tz_INMeu6c";
        _baseUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch/json";
        _client = new HttpClient();
    }

    public async Task<List<Place>> GetCoordinatesAsync(string latitude, string longitude, int radius)
    {
        List<Place> locations = new List<Place>();
        string url = $"{_baseUrl}?location={latitude},{longitude}&radius={radius}&type=point_of_interest&language=en&key={_apiKey}";
        Debug.WriteLine(url);
        var next_page_token = "";
        while (next_page_token != null)
        {
            HttpResponseMessage response = await _client.GetAsync($"{url}&next_page_token={next_page_token}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var details = JObject.Parse(json);
                var places = GetPlaces(details["results"]);
                locations.AddRange(places);
                Debug.WriteLine(locations[0].Name);
                next_page_token = details.TryGetValue("next_page_token", out JToken value) ? value.ToString() : null;
            }
        }
        return locations;
    }

    private List<Place> GetPlaces(JToken locations)
    {
        List<Place> places = new List<Place>();
        foreach (var location in locations)
        {
            double.TryParse(location["geometry"]["location"]["lat"].ToString(), out double lat);
            double.TryParse(location["geometry"]["location"]["lng"].ToString(), out double lng);
            places.Add(new Place()
            {
                Lat = lat,
                Lng = lng,
                Name = location["name"].ToString()
            });
            Debug.WriteLine(places[0].Name);
        }
        return places;
    }
}
