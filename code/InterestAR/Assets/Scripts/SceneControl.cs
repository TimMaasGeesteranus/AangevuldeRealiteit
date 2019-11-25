using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Android;

public class SceneControl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        PermissionHandler();
    }

    // Update is called once per frame
    void Update()
    {
        GoToRetry();
        ClickToContinue();
    }

    void ClickToContinue()
    {
        if (Input.touchCount > 0 && Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            SceneManager.LoadScene("CameraScene");
        }
    }

    public void PermissionHandler()
    {
        /* Ask for permission */
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
    }

    public void GoToRetry()
    {
        /* No permission, go to prompt*/
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            SceneManager.LoadScene("PromptPermissionScene");
        }
    }
}
