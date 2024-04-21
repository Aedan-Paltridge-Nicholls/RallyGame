using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class PauseScript : MonoBehaviour
{
    public FloatVariable Volume;

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
    /// <summary>
    /// Shows/Hides the Pause Menu 
    /// and when it does that it also 
    /// Mutes/Unmutes the audio
    /// </summary>
    public  void TogglePause()
    {

        bool isPaused = !Time.timeScale.Equals(0f);
        Time.timeScale = isPaused ? 0f : 1f;
        AudioListener.volume = isPaused ? 0f : Volume.Value;
        PauseMenu.enabled  =  (isPaused) ? true : false;

        // Show/hide pause menu UI accordingly
    }
}
