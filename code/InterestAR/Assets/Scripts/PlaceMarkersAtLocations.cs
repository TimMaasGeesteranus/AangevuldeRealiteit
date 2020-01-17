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
        public GameObject PlaceOfInterestDescription;

        private void Start()
        {

            var places =  mapsService.GetCoordinates("51.825764", "5.865534", 100);

            foreach(var place in places) {
                AddLocation(place);
            }
           
        }

        public void AddLocation(Place place)
        {
            var loc = new Location()
            {
                Latitude = place.Lat,
                Longitude = place.Lng,
                Altitude = 0,
                AltitudeMode = AltitudeMode.DeviceRelative
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

            //create a copy of the description for individual interaction
            GameObject description = GameObject.Instantiate(PlaceOfInterestDescription);

            PlaceAtLocation.AddPlaceAtComponent(place.MarkerModel, loc, opts);

            Markers.MarkersWithDescriptions.Add(place.MarkerModel, description);
        }
    }
}
