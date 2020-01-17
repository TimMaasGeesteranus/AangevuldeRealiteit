using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Dto;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ToggleDescription : MonoBehaviour
    {
        public void OnMouseDown()
        {
            Markers.MarkersWithDescriptions.TryGetValue(gameObject, out GameObject description);

            if (description != null)
            {
                Text scrollable = description.transform.GetChild(0).GetChild(0).GetComponent<Text>();
                Text title = description.transform.GetChild(1).GetChild(0).GetComponent<Text>();

                description.SetActive(!description.activeSelf);
            }
        }
    }
}
