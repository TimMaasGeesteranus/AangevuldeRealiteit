using ARLocation;
using Assets.Scripts.Services;
using Assets.Scripts.Dto;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;
using System;

namespace Assets.Scripts
{
    public class PlaceMarkersAtLocations : MonoBehaviour
    {
        private List<Place> places = new List<Place>();

        public GameObject Marker;
        public GoogleMapsService mapsService = new GoogleMapsService();
        public ARLocationProvider provider;
        double startLocationLat = 0;
        double startLocationLng = 0;
        double currentLocationLat = 0;
        double currentLocationLng = 0;

        public void Update()
        {
            var userLocation = provider.CurrentLocation;

            currentLocationLat = userLocation.latitude;
            currentLocationLng = userLocation.longitude;

            if (currentLocationLat != 0 || currentLocationLng != 0)
            {
                if (startLocationLat == 0)
                {
                    startLocationLat = userLocation.latitude;
                    startLocationLng = userLocation.longitude;
                    _ = Task.Run(() => LoadPlaces());
                }
                else if (LocationChangedMoreThan10Meters(startLocationLat, startLocationLng, currentLocationLat, currentLocationLng))
                {
                    startLocationLat = currentLocationLat;
                    startLocationLng = currentLocationLng;
                    _ = Task.Run(() => UnLoadPlaces());
                    _ = Task.Run(() => LoadPlaces());
                }
            }
        }

        public void UnLoadPlaces()
        {
            foreach (var place in MarkerStorage.ActiveMarkers)
            {
                GameObject.Destroy(place.Value.gameObject);
            }
            MarkerStorage.ActiveMarkers.Clear();
        }

        public async void LoadPlaces()
        {
            int distance = (int)MemoryDataService.Distance;
            places = await mapsService.GetCoordinatesAsync(currentLocationLat.ToString(), currentLocationLng.ToString(), distance);
            foreach (var place in places)
            {
                AddLocation(place);
            }
        }

        public bool LocationChangedMoreThan10Meters(double startLocationLat, double startLocationLng, double currentLocationLat, double currentLocationLng)
        {
            if (startLocationLat == 0 || currentLocationLat == 0)
            {
                return false;
            }
            else
            {
                var d1 = startLocationLat * (Math.PI / 180.0);
                var num1 = startLocationLng * (Math.PI / 180.0);
                var d2 = currentLocationLat * (Math.PI / 180.0);
                var num2 = currentLocationLng * (Math.PI / 180.0) - num1;
                var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

                var dist = 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));

                if (dist > 30)
                {
                    return true;
                }
                return false;
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