using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformatieOpener : MonoBehaviour
{

    public GameObject Informatie;

    public void openInformatie()
    {
        Debug.Log("HALLO");
        if(Informatie != null)
        {
            Informatie.SetActive(!Informatie.activeSelf);
        }
    }
}
