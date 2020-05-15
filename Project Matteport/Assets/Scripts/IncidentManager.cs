using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class IncidentManager : MonoBehaviour
{

    public static bool isManagerOpen = false;

    public GameObject incidentManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isManagerOpen) {
                Deactivate();
            }
            else
            {
                 Activate();
            }
        }
        void Deactivate()
        {

            incidentManager.SetActive(false);
            Time.timeScale = 1f;
            isManagerOpen = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Activate()
        {
            incidentManager.SetActive(true);
            Time.timeScale = 0f;
            isManagerOpen = true;

            Cursor.lockState = CursorLockMode.None;

        }



    }

    
      

    
}
