using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ToggleVisibility : MonoBehaviour
    {
        public GameObject Object;

        public void OnMouseDown()
        {
            Debug.Log("TOGGLING ACITVATED");
            if (Object != null)
            {
                Object.SetActive(!Object.activeSelf);
            }
        }
    }
}
