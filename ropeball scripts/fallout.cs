using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallout : MonoBehaviour
{


    public GameObject lostmenuUI;
    public AudioSource nyerteshang;
    public GameObject timer;
    public GameObject ropecuter;





    void OnTriggerEnter2D(Collider2D colInfo)
    {




        if (colInfo.CompareTag("Player"))
        {
            lostmenuUI.SetActive(true);

            timer.SetActive(false);
            ropecuter.SetActive(false);


        }
        else if (colInfo.CompareTag("blackdot"))
        {
            lostmenuUI.SetActive(true);

            timer.SetActive(false);
            ropecuter.SetActive(false);

        }
    }
}