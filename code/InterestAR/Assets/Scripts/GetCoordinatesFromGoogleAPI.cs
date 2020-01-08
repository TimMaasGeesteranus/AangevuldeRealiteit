using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class GetCoordinatesFromGoogleAPI : MonoBehaviour
{
    public string PointOfInterest;
    public Text ChangingText;
    
    void Start()
    {
        var json = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/place/textsearch/json?query=places+in+parijs&key=AIzaSyC3wh6HCkeu9LLjCvCq2CA0AWg-pfpoegc");
        var details = JObject.Parse(json);
        var results = details["results"];
        foreach (var obj in results)
        {
            if (obj["name"].ToString() == PointOfInterest)
            {
                ChangingText.text = string.Concat("Lat: ", ((obj["geometry"])["location"])["lat"], " - Let: ", ((obj["geometry"])["location"])["lng"]);
            };
        };
    }
}
