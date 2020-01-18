using ARLocation;
using System.Diagnostics;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

namespace Assets.Scripts
{
    public class PlaceMarkersAtLocations : MonoBehaviour
    {
        public GameObject Marker;
        public GoogleMapsService mapsService = new GoogleMapsService();

        private async void Start()
        {
            var places =  await mapsService.GetCoordinatesAsync("51.598190700981874", "6.054871073400005", 10000);
            Debug.WriteLine(places.Count);
            foreach(var place in places) {
                Debug.WriteLine(place.Lat);
                Debug.WriteLine(place.Lng);
                AddLocation(place.Lat, place.Lng);
            }
           
        }

        public void AddLocation(double latitude, double longitude)
        {
            var loc = new Location()
            {
                Latitude = latitude,
                Longitude = longitude,
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

            PlaceAtLocation.AddPlaceAtComponent(Marker, loc, opts);
        }
    }
}
