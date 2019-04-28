using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class mainmenu : MonoBehaviour {

    //public Button tiltControlButton;
    //public Color tiltControlEnabled;
    //public Color tiltcontrolDisabled;

    public void PlayGame ()
    {
        
        SceneManager.LoadScene("characterselect");

       //if (SystemInfo.supportsAccelerometer)
       //{
         //   tiltControlButton.GetComponent<Image>().color = (SaveManager.Instance.state.usingAccelerometer) ? tiltControlEnabled : tiltcontrolDisabled;
       //}

       //else
       //{
         //   tiltControlButton.gameObject.SetActive(false);
       //}
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
  //  public void OnTiltControl()
    //{
      //  SaveManager.Instance.state.usingAccelerometer = !SaveManager.Instance.state.usingAccelerometer;
      
      //  SaveManager.Instance.Save();


        //tiltControlButton.GetComponent<Image>.color = (SaveManager.Instance.state.usingAccelerometer) ? tiltControlEnabled : tiltcontrolDisabled;
    //}

}
