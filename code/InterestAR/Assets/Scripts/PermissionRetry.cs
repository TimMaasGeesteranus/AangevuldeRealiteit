using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PermissionRetry : MonoBehaviour
{
    public Button promptButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = promptButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Permission.RequestUserPermission(Permission.Camera);
    }

    void Update()
    {
        if (Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            SceneManager.LoadScene("CameraScene");
        }
    }
}
