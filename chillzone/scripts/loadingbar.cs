using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadingbar : MonoBehaviour {

    public GameObject loadingbaar;
    public GameObject textindicator;
    public GameObject textloading;
    public AudioSource viz;
    public GameObject exitbutton;
    public GameObject stopbutton;



    public float currentamount;

   
    public float speed;

    

    public void start()
    {
        
        loadingbaar.SetActive(true);
        viz.Play();




    }
    

        


    



    // Update is called once per frame
    public void Update ()
    
    {
            
            if (currentamount < 100)
            {
                
                currentamount += speed * Time.deltaTime;
                textindicator.GetComponent<Text>().text = ((int)currentamount).ToString() + "";
                textloading.gameObject.SetActive(true);
               


        }
            else
            {
                
                textloading.gameObject.SetActive(false);
                textindicator.GetComponent<Text>().text = "vege";
                

            }
            loadingbaar.GetComponent<Image>().fillAmount = currentamount / 100;
        

    }

    public void QuitGame()
    {
        loadingbaar.SetActive(false);
        Debug.Log("Quit");
        Application.Quit();

    }
    public void stop()
    {
        stopbutton.SetActive(false);
        loadingbaar.SetActive(false);
        exitbutton.SetActive(true);
        viz.Stop();


    }
}
