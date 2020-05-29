using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public static bool isPauseMenuOpen = false;
    public GameObject pauseMenu;


     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPauseMenuOpen)
            {
                Deactivate();
            }
            else
            {
                Activate();
            }
        }
        void Deactivate()
        {

            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isPauseMenuOpen = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Activate()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isPauseMenuOpen = true;

            Cursor.lockState = CursorLockMode.None;

        }
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
