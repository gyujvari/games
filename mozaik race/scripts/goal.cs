using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class goal : MonoBehaviour {

    public GameObject retrymenu;

	void OnTriggerEnter2D (Collider2D colInfo)
    {
        if (colInfo.CompareTag("Player"))
        {
            retrymenu.SetActive(true);
            //SceneManager.LoadScene(1);
        }

    }
}
