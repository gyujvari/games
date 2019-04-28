using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Pickup();
        }

    }
    void Pickup()
    {
        Debug.Log("Power picked up");
    }
}
