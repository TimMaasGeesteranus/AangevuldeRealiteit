using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Android;

namespace Assets.Scripts
{
    public class SceneControl : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(AskForPermissions());
        }

        // Update is called once per frame
        void Update()
        {
            ClickToContinue();
        }

        void ClickToContinue()
        {
            if (Input.touchCount > 0)
            {
                if (Permission.HasUserAuthorizedPermission(Permission.Camera) && Permission.HasUserAuthorizedPermission(Permission.FineLocation))
                {
                    SceneManager.LoadScene("CameraScene");
                }
                else
                {
                    SceneManager.LoadScene("PromptPermissionScene");
                }
            }
        }

        private IEnumerator AskForPermissions()
        {
            List<bool> permissions = new List<bool>() { false, false };
            List<bool> permissionsAsked = new List<bool>() { false, false };

            List<Action> actions = new List<Action>()
            {
                new Action(() =>
                {
                    permissions[0] = Permission.HasUserAuthorizedPermission(Permission.Camera);
                    if (!permissions[0] && !permissionsAsked[0])
                    {
                        Permission.RequestUserPermission(Permission.Camera);
                        permissionsAsked[0] = true;
                        return;
                    }
                }),
                new Action(() =>
                {
                    permissions[1] = Permission.HasUserAuthorizedPermission(Permission.FineLocation);
                    if (!permissions[1] && !permissionsAsked[1])
                    {
                        Permission.RequestUserPermission(Permission.FineLocation);
                        permissionsAsked[1] = true;
                        return;
                    }
                })
            };

            for (int i = 0; i < permissionsAsked.Count;)
            {
                actions[i].Invoke();
                if (permissions[i])
                {
                    ++i;
                }

                yield return new WaitForEndOfFrame();
            }
        }
    }
}