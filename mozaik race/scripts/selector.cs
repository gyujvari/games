using UnityEngine;
using System.Collections;

public class selector : MonoBehaviour
{

    public GameObject bogar;
    public GameObject mini;
    public GameObject e92; 
    



    public int carSelected;

    void Start()
    {

        bogar.SetActive(true);
        mini.SetActive(false);
        e92.SetActive(false);
        

        carSelected = 1;
    }

    public void loadbogar()
    {

        bogar.SetActive(true);
        mini.SetActive(false);
        e92.SetActive(false);
        


        carSelected = 1;
    }

    public void loadmini()
    {

        bogar.SetActive(false);
        mini.SetActive(true);
        e92.SetActive(false);
        


        carSelected = 2;
    }
    public void loade92()
    {
        e92.SetActive(true);
        bogar.SetActive(false);
        mini.SetActive(false);
        

        carSelected = 3;
    }


}