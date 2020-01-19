using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Dto;
using UnityEngine.UI;
using Assets.Scripts.Services;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class SetDescriptionText : MonoBehaviour
    {
        public GameObject PlaceOfInterestDescription;

        public async void OnMouseDown()
        {
            if (PlaceOfInterestDescription != null)
            {
                Text scrollable = PlaceOfInterestDescription.transform.GetChild(0).GetChild(0).GetComponent<Text>();
                Text title = PlaceOfInterestDescription.transform.GetChild(1).GetChild(0).GetComponent<Text>();

                if (title.text == gameObject.name && PlaceOfInterestDescription.activeSelf)
                {
                    PlaceOfInterestDescription.SetActive(false);
                }
                else if (MarkerStorage.ActiveMarkers.ContainsKey(gameObject))
                {
                    PlaceOfInterestDescription.SetActive(true);

                    title.text = gameObject.name;
                    scrollable.text = await WikipediaService.FullSearch(gameObject.name);
                }
            }
        }
    }
}
