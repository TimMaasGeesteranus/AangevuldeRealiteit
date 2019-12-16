using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToCamera : MonoBehaviour
{
    public Button CloseButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = CloseButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("CameraScene");
    }
}
