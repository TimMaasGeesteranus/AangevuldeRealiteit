using ARLocation;
using Assets.Scripts.Services;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

namespace Assets.Scripts
{
    public class PlaceMarkersAtLocations : MonoBehaviour
    {
        public GameObject Marker;
        public GameObject LocationProvider;
        public GoogleMapsService mapsService = new GoogleMapsService();
        public LocationReading locationProvider;
        public LocationReading userLocation;
        private List<Place> places;

        public void Start()
        {
            ARLocationProvider provider = LocationProvider.GetComponent<ARLocationProvider>();
            locationProvider = provider.CurrentLocation;
            Debug.WriteLine(locationProvider);
        }

        public async void Update()
        {
            Debug.WriteLine(locationProvider);
            if (places.Count <= 0)
            {
                string lat = userLocation.latitude.ToString();
                string lng = userLocation.longitude.ToString();

                int distance = (int)MemoryDataService.Distance;
                places = await mapsService.GetCoordinatesAsync(lat, lng, distance);
                Debug.WriteLine(places.Count);
                foreach (var place in places)
                {
                    AddLocation(place.Lat, place.Lng);
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
