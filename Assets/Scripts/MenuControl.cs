using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Canvas MainMenu;
    [SerializeField] Canvas SettingsMenu;
    void Start()
    {
        MainMenu.enabled = true;
        SettingsMenu.enabled = false;
    }
    public void play()
    {
        AudioListener.volume = 1.0f;
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        MainMenu.enabled = true;
        SettingsMenu.enabled = false;
    }
    public void Settings()
    {
        MainMenu.enabled = false;
        SettingsMenu.enabled = true;
    }
    
}
