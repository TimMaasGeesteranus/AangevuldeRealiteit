using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Dto;
using UnityEngine.UI;
using Assets.Scripts.Services;
using System.Threading.Tasks;
using ARLocation;

namespace Assets.Scripts
{
    public class SetDescriptionText : MonoBehaviour
    {
        public GameObject PlaceOfInterestDescription;
        public Text Title;
        public Text Description;

        private static GameObject lastClickedMarker;

        public async void OnMouseDown()
        {
            MarkerStorage.ActiveMarkers.TryGetValue(gameObject, out PlaceAtLocation marker);

            if (PlaceOfInterestDescription != null && marker != null)
            {
                if (lastClickedMarker == gameObject && PlaceOfInterestDescription.activeSelf)
                {
                    PlaceOfInterestDescription.SetActive(false);
                }
                else
                {
                    PlaceOfInterestDescription.SetActive(true);

                    lastClickedMarker = gameObject;

                    Title.text = await WikipediaService.GetOpenSearch(gameObject.name, MemoryDataService.Language);
                    Description.text = await WikipediaService.FullSearch(gameObject.name, MemoryDataService.Language);
                }
            }
        }
    }
}
