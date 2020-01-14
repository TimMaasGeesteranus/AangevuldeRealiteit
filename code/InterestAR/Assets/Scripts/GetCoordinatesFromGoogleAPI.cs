using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class GetCoordinatesFromGoogleAPI : MonoBehaviour
{
    public Text ChangingText;
    
    void Start()
    {
        Debug.Log("getcoordinates");
        var json = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=51.825764,%205.865534&radius=1000&type=point_of_interest&key=AIzaSyD1akMvc1-cVQ_KaZBYgCgzEOdlmAopN10");
        var details = JObject.Parse(json);
        var results = details["results"];

        var opgehaaldeData = new List<string>();

        foreach (var obj in results)
        {
            // Debug.Log(string.Concat("Name: ", (obj["name"]), "  -  Lat: ", ((obj["geometry"])["location"])["lat"], " - Let: ", ((obj["geometry"])["location"])["lng"]));

            var lat = (((obj["geometry"])["location"])["lat"]).ToString();
            var lng = (((obj["geometry"])["location"])["lng"]).ToString();
            var name = (obj["name"]).ToString();

            string[] input = { lat, lng, name };
            opgehaaldeData.AddRange(input);
        };

        ChangingText.text = opgehaaldeData.ToString();
        string weergaveTekst = "";
        foreach(object o in opgehaaldeData){
            weergaveTekst = string.Concat(weergaveTekst, o, " - ");
        }
        ChangingText.text = weergaveTekst;
    }
}
