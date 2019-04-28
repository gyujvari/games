using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splashfade : MonoBehaviour {

    public Image splashimage;
    public string loadlevel;
    public AudioSource huss;
	// Use this for initialization
	IEnumerator Start () {
        splashimage.canvasRenderer.SetAlpha(0.0f);
        FadeIn();
        yield return new WaitForSeconds(2.5f);
        
        FadeOut();
        yield return new WaitForSeconds(2.5f);
       
        SceneManager.LoadScene(loadlevel);
		
	}
	
     void FadeIn()
    {
        
        splashimage.CrossFadeAlpha(1.0f, 1.5f, false);
        
    }

     void FadeOut()
    {
        splashimage.CrossFadeAlpha(0.0f, 2.5f, false);
        

    }
}
