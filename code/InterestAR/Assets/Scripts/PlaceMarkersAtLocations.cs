using ARLocation;
using Assets.Scripts.Dto;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlaceMarkersAtLocations : MonoBehaviour
    {
        public GameObject Marker;
        public GoogleMapsService mapsService = new GoogleMapsService();

        private void Start()
        {
            //var places =  mapsService.GetCoordinates("51.825764", "5.865534", 100);

            //foreach(var place in places) {
            //    AddLocation(place);
            //}

            AddLocation(new Place { Lat = 51.826330, Lng = 5.865145, Name = "Eiffel Tower" });
            AddLocation(new Place { Lat = 51.826309, Lng = 5.865148, Name = "Notre-Dame" });
        }

        public void AddLocation(Place place)
        {
            var loc = new Location()
            {
                Latitude = place.Lat,
                Longitude = place.Lng,
                Altitude = 0,
                AltitudeMode = AltitudeMode.GroundRelative
            };

            var opts = new PlaceAtLocation.PlaceAtOptions()
            {
                HideObjectUntilItIsPlaced = true,
                MaxNumberOfLocationUpdates = 0,
                MovementSmoothing = 0.1f,
                UseMovingAverage = false
            };

            //create a copy of the model for individual interaction
            place.MarkerModel = GameObject.Instantiate(Marker);
            place.MarkerModel.name = place.Name;
            place.MarkerModel.SetActive(true);

            PlaceAtLocation marker = PlaceAtLocation.AddPlaceAtComponent(place.MarkerModel, loc, opts);

            MarkerStorage.ActiveMarkers.Add(place.MarkerModel, marker);
        }
    }
}
