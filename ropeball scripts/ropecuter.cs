﻿
using UnityEngine;

public class ropecuter : MonoBehaviour {

    public AudioSource szakadashang;
   
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.tag == "Link")
                {
                    szakadashang.Play();
                    Destroy(hit.collider.gameObject);
                    Destroy(hit.transform.parent.gameObject, 0.1f);
                    
                }

            }
            
        }	

    
	}
}
