

using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;









public class endgame : MonoBehaviour
{

    public GameObject winmenuUI;
    public GameObject lostmenuUI;
    public AudioSource nyerteshang;
    public GameObject timer;
    public GameObject ropecuter;
    




    void OnTriggerEnter2D(Collider2D colInfo)
    {
       

        

        if (colInfo.CompareTag("Player"))
        {
            winmenuUI.SetActive(true);
            nyerteshang.Play();
            timer.SetActive(false);
            ropecuter.SetActive(false);
           

        }

      




    }
    































}   
 
