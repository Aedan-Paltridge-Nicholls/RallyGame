using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
