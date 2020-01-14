using ARLocation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlaceMarkersAtLocations : MonoBehaviour
    {
        public GameObject Marker;

        private void Start()
        {
            AddLocation(51.826474, 5.864405);
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
