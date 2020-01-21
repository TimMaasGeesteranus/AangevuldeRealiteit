using ARLocation;
using Assets.Scripts.Services;
using Assets.Scripts.Dto;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class PlaceMarkersAtLocations : MonoBehaviour
    {
        private List<Place> places = new List<Place>();
        
        public GameObject Marker;
        public GoogleMapsService mapsService = new GoogleMapsService();
        public ARLocationProvider provider;

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
                        AddLocation(place);
                    }
                }
            }
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
            place.MarkerModel = Instantiate(Marker);
            place.MarkerModel.name = place.Name;
            place.MarkerModel.SetActive(true);

            PlaceAtLocation marker = PlaceAtLocation.AddPlaceAtComponent(place.MarkerModel, loc, opts);

            MarkerStorage.ActiveMarkers.Add(place.MarkerModel, marker);
        }
    }
}
