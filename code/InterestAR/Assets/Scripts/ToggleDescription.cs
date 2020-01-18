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
            MarkerStorage.MarkersWithDescriptions.TryGetValue(gameObject, out GameObject description);

            if (description != null)
            {
                Canvas cameraSceneCanvas = GameObject.Find("CameraSceneCanvas").GetComponent<Canvas>();

                var visibleDescription = cameraSceneCanvas.GetComponent("PlaceOfInterestDescription");

                if (visibleDescription != null) 
                {
                    Destroy(visibleDescription);
                }

                if (!description.activeSelf) 
                {
                    //Text scrollable = description.transform.GetChild(0).GetChild(0).GetComponent<Text>();
                    Text title = description.transform.GetChild(1).GetChild(0).GetComponent<Text>();

                    title.text = gameObject.name;

                    description.transform.SetParent(cameraSceneCanvas.transform, false);
                }

                description.SetActive(!description.activeSelf);;
            }
        }
    }
}
