using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventScript : MonoBehaviour
{
    
    private void Start()
    {
    }
    // Start is called before the first frame update
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);

    }
    public void LoadMenu()
    {
        AudioListener.volume = 1.0f;
        SceneManager.LoadScene(0);
        

    }
    public void LoadSettings()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        AudioListener.volume = 1.0f;
        SceneManager.LoadScene(1);        
        Time.timeScale = 1f;
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
