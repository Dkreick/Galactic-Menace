using UnityEngine;
using System.Collections;

public class OpenPauseMenu : MonoBehaviour
{
    public GameObject PauseMenu;
    void Update()
    {
        if (Input.GetKeyDown("P"))
        {
            PauseMenu.SetActive(true);
            print("space key was pressed");
        }
    }
}