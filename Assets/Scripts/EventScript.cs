using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventScript : MonoBehaviour
{   

    // Start is called before the first frame update
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);

    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;


    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
