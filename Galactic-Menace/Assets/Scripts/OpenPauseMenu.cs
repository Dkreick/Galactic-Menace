using UnityEngine;
using System.Collections;

public class OpenPauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
        void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Escape)) 
        {
            if (!pauseMenu.activeInHierarchy) 
            {
                PauseGame();
            }
            if (pauseMenu.activeInHierarchy) 
            {
                ContinueGame();   
            }
        } 
     }
    private void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    } 
    private void ContinueGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}

