using ARLocation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Dto
{
    public static class MarkerStorage
    {
        public static Dictionary<GameObject, PlaceAtLocation> ActiveMarkers = new Dictionary<GameObject, PlaceAtLocation>();
    }
}