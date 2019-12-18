using System.Collections;
using UnityEngine;

public class GPS : MonoBehaviour
{
    public float Latitude;
    public float Longitude;

    public static GPS Instance;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
    }

    private IEnumerator StartLocationService()
    {
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("User has not enabled GPS");
            yield break;
        }

        Input.location.Start();
        int maxWait = 20;

        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if (maxWait <= 0)
        {
            Debug.Log("Unable to determine device location");
            yield break;
        }

        Latitude = Input.location.lastData.latitude;
        Longitude = Input.location.lastData.longitude;
    }


}
