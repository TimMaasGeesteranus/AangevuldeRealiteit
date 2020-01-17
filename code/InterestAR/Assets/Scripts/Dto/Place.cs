using UnityEngine;

namespace Assets.Scripts.Dto
{
    public class Place
    {
        public GameObject MarkerModel { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Name { get; set; }
    }
}
