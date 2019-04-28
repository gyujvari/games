using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class dataimplementer : MonoBehaviour
{


    public int carSelected;
    public int trackSelected;
    Vector3[] trackCoordinate;

    public GameObject bogar;
    public GameObject mini;
    public GameObject e92;
    public GameObject minicamera;
    public GameObject e92camera;
    public GameObject bogarcamera; 
    public GameObject darklightmini;
    public GameObject darklghtbogar;
    public GameObject darklighte92;


    Transform car;



   public void Start()
    {

        carSelected = GameObject.Find("DataHandler").GetComponent<datahandler>().carSel;
        trackSelected = GameObject.Find("DataHandler").GetComponent<datahandler>().trackSel;

        if (carSelected == 1)
        {
            bogar.SetActive(true);
            mini.SetActive(false);
            e92.SetActive(false);
            bogarcamera.SetActive(true);
            e92camera.SetActive(false);
            minicamera.SetActive(false);
            darklghtbogar.SetActive(true);
            darklighte92.SetActive(false);
            darklightmini.SetActive(false);

        }

        else if (carSelected == 2)
        {

            bogar.SetActive(false);
            mini.SetActive(true);
            e92.SetActive(false);
            bogarcamera.SetActive(false);
            e92camera.SetActive(false);
            minicamera.SetActive(true);
            darklghtbogar.SetActive(false);
            darklighte92.SetActive(false);
            darklightmini.SetActive(true);
        }


        else if (carSelected == 3)
        {
            e92.SetActive(true);
            bogar.SetActive(false);
            mini.SetActive(false);
            bogarcamera.SetActive(false);
            e92camera.SetActive(true);
            minicamera.SetActive(false);
            darklghtbogar.SetActive(false);
            darklighte92.SetActive(true);
            darklightmini.SetActive(false);


        }



        //car.position = trackCoordinate[trackSelected - 1];
    }

    void Update()
    {

    }
}
