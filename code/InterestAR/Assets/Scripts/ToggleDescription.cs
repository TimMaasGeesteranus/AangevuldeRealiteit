using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Dto;

namespace Assets.Scripts
{
    public class ToggleDescription : MonoBehaviour
    {
        public void OnMouseDown()
        {
            if (gameObject != null)
            {
                Markers.MarkersWithDescriptions.TryGetValue(gameObject, out GameObject description);

                if (description != null)
                {
                    GameObject scrollable = description.transform.GetChild(0).gameObject;
                    GameObject title = description.transform.GetChild(1).gameObject;

                    description.SetActive(!description.activeSelf);
                }
            }
        }
    }
}
