using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloader : MonoBehaviour {
    public GameObject loadingscreen;
    public Slider slider;
    public GameObject mainmenu;
   
    public void loadlevel(int sceneIndex)
         
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }
    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        
        
        loadingscreen.SetActive(true);
        mainmenu.SetActive(false);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;

        }
    }
}
