using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventScript : MonoBehaviour
{
    public IntegerVariable  Level;
    public IntegerVariable  LevelTotal;
   
    private void Start()
    {
        Level.value = SceneManager.GetActiveScene().buildIndex; 
        
        Debug.Log($"Level : {Level.value} ");
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
    
    public void NextLevel()
    {
        //Debug.Log($"currant Level : {Level.value} ");

        Level.value = (Level.value == LevelTotal.value) ? 0 : SceneManager.GetActiveScene().buildIndex + 1;
      
       // Debug.Log($"Next Level : {Level.value} ");

        LoadGame();
    }

    public void LoadGame()
    {
        AudioListener.volume = 1.0f;

        SceneManager.LoadScene(Level.value);        
        Time.timeScale = 1f;
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
