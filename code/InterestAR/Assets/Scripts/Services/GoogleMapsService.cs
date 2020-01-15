using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class GoogleMapsService
{
    public List<Place> GetCoordinates(string latitude, string longitude, int radius)
    {
        string googleMapsURL = $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={latitude},{longitude}&radius={radius}&type=point_of_interest&key=AIzaSyDWnKL07Y0zk_IHGypBUiUF2Tz_INMeu6c";
        //string googleMapsURL = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=51.825764,%205.865534&radius=1000&type=point_of_interest&key=AIzaSyDWnKL07Y0zk_IHGypBUiUF2Tz_INMeu6c";
        var json = new WebClient().DownloadString(googleMapsURL);
        var details = JObject.Parse(json);

        var locations = details["results"];

        List<Place> places = new List<Place>();
        foreach(var location in locations)
        {
            double.TryParse(location["geometry"]["location"]["lat"].ToString(), out double lat);
            double.TryParse(location["geometry"]["location"]["lng"].ToString(), out double lng);
            double.TryParse(location["name"].ToString(), out double ba);

           places.Add(new Place()
            {
                Lat = lat,
                Lng = lng,
                Name = location["name"].ToString()
            });
        }
        return places;
     }
}
