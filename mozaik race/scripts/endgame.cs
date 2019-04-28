
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;






public class endgame : MonoBehaviour {

    public GameObject RetrymenuUI;

    public static bool GameIsFailed = false;
    private bool wannaquit;

    void Update()
    {
        if (GameIsFailed)
        {
            RetrymenuUI.SetActive(true);
            Time.timeScale = 0f;
            if (wannaquit)
            {
                quit();
            }
            else
            {
                Retry();

            }
        }
        
    }

    void OnTriggerEnter2D()
    {
        GameIsFailed = true;
        //SceneManager.LoadScene(2);
    }
    public void Retry()
    {
        wannaquit = false;
        Debug.Log("load");
        SceneManager.LoadScene(3);
    }

    public void quit()
    {
        wannaquit = true;
        Debug.Log("quitting game");
        Application.Quit();
    }

    public void ujra()
    {
        SceneManager.LoadScene(2);
    }


}
