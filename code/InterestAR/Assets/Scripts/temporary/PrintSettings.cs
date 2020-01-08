using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Dit is de data uit MemoryDataService.cs: ");
        Debug.Log(MemoryDataService.Distance);
        Debug.Log(MemoryDataService.Language);

    }

    // Update is called once per frame
    void Update()
    {


    }
}
