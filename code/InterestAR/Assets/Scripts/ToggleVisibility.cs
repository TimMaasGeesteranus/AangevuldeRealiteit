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
            if (Object != null)
            {
                Object.SetActive(!Object.activeSelf);
            }
        }
    }
}
