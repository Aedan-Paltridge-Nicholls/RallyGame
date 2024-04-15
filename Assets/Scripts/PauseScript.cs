using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class PauseScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.enabled = false;
    }
    [SerializeField] Canvas  PauseMenu;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            
            TogglePause();
        }
    }

    public  void TogglePause()
    {

        bool isPaused = !Time.timeScale.Equals(0f);
        Time.timeScale = isPaused ? 0f : 1f;
        AudioListener.volume = isPaused ? 0f : 1f;
        PauseMenu.enabled  =  (isPaused) ? true : false;

        // Show/hide pause menu UI accordingly
    }
}
