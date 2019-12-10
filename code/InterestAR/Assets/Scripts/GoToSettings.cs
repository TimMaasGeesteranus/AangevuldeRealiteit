using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToSettings : MonoBehaviour
{
    public Button SettingsButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = SettingsButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("SettingsScreen");
    }

    void Update()
    {
    }
}
