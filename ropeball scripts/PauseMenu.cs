using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    
    private bool PauseIsPressed;
    private bool PauseIsNotPressed;

    public GameObject pauseMenuUI;
   

    // Update is called once per frame
    void Update () {
    
       if (PauseIsNotPressed)
        {
            

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

       else if (PauseIsPressed)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;

            
        }

      


    }
    //public void TogglePauseMenu()
    //{
      //  pauseMenuUI.SetActive(!pauseMenuUI.activeSelf);
    //}

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseIsPressed = false;


    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    

    public void loadmenu()
    {
        Debug.Log("menu");
        SceneManager.LoadScene(0);
    }

    public void quitgame()
    {
        Debug.Log("quitting game");
        Application.Quit();
    }
    

    public void PausePressed()
    {
        PauseIsPressed = true;



    }

    public void PauseNotPressed()
    {
        PauseIsNotPressed = true;



    }


   
}
