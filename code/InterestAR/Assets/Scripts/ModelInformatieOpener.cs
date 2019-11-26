using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelInformatieOpener : MonoBehaviour
{
    public GameObject Informatie;

    public void OnMouseDown()
    {
        Debug.Log("HOI");
        if (Informatie != null)
        {
            Informatie.SetActive(!Informatie.activeSelf);
        }
    }
}
