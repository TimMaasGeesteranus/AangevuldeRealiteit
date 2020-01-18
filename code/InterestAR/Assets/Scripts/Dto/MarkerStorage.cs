using ARLocation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Dto
{
    public static class MarkerStorage
    {
        public static Dictionary<GameObject, GameObject> MarkersWithDescriptions = new Dictionary<GameObject, GameObject>();
    }
}