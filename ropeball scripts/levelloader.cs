using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour {

    public string leveltoload;
    public string curentlevel;

    public void loading()
    {
        SceneManager.LoadScene(leveltoload);
    }
    // Use this for initialization

    public void retry()
    {
        SceneManager.LoadScene(curentlevel);
    }

}
