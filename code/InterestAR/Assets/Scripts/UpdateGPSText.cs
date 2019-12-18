using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPSText : MonoBehaviour
{
    public Text Coordinates;

    // Update is called once per frame
    void Update()
    {
        Coordinates.text = "LAT:" + GPS.Instance.Latitude.ToString() + "LON" + GPS.Instance.Longitude.ToString();
    }
}
