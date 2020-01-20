using ARLocation;
using Assets.Scripts.Services;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class PlaceMarkersAtLocations : MonoBehaviour
    {
        public GameObject Marker;
        public GoogleMapsService mapsService = new GoogleMapsService();
        public ARLocationProvider provider;
        public Text text;

        private List<Place> places = new List<Place>();

        public async void Update()
        {
            var userLocation = provider.CurrentLocation;
            if (places.Count <= 0)
            {
                if (userLocation.latitude + userLocation.latitude > 0)
                {
                    string lat = userLocation.latitude.ToString();
                    string lng = userLocation.longitude.ToString();

                    int distance = (int)MemoryDataService.Distance;
                    places = await mapsService.GetCoordinatesAsync(lat, lng, distance);

                    foreach (var place in places)
                    {
                        AddLocation(place.Lat, place.Lng);
                    }
                }

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
